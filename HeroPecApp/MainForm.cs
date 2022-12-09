using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;
using System.Security.Cryptography;
using HeroPecApp.ConnectionFTP;

namespace HeroPecApp
{
    public partial class MainForm : Form
    {

        private Point mPoint = new Point();
        private static bool isOflline = false;
        private string currentHashPassword;
        private string userZip = $"{Environment.CurrentDirectory}\\TempData\\{Connection.CurrentUser.userid}.zip";
        private string heroZip = (Properties.Settings.Default.LocalPath == ""
            ? $"{Environment.CurrentDirectory}\\DataFiles"
            : Properties.Settings.Default.LocalPath) + "\\HeroData.zip";

        public static string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        private void CheckDirectory()
        {
            if (!File.Exists(heroZip))
            {
                Directory.CreateDirectory(heroZip.Replace("\\HeroData.zip", ""));
                using (ZipFile zip = new ZipFile())
                {
                    zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                    zip.Save(userZip);
                    zip.Password = currentHashPassword;
                    zip.AddFile(userZip, "");
                    zip.Save(heroZip);
                }
            }

            using (ZipFile zip = new ZipFile(heroZip))
            {
                zip.Password = currentHashPassword;
                if (File.Exists(userZip))
                {
                    File.Delete(userZip);
                }
                var uZip = zip.Entries.FirstOrDefault(en => en.FileName == $"{Connection.CurrentUser.userid}.zip");
                if (uZip is null)
                {
                    zip.Save(userZip);
                }
                else
                {
                    uZip.Extract($"{Environment.CurrentDirectory}\\TempData");
                }
            }
        }

        private void AddFile()
        {
            loadPictureBox.Visible = true;
            var addFile = new OpenFileDialog();
            if (addFile.ShowDialog() == DialogResult.OK)
            {
                using (var zip = new ZipFile(userZip))
                {
                    zip.AddFile(addFile.FileName, "");
                    zip.Save(userZip);
                }
            }
            loadPictureBox.Visible = false;
        }

        private void DeleteFile()
        {
            if (localFilesListView.SelectedItems.Count != 0)
            {
                using (var zip = new ZipFile(userZip))
                {
                    foreach (ListViewItem item in localFilesListView.SelectedItems)
                    {
                        zip.RemoveEntry(item.Text);
                        zip.Save(userZip);
                    }
                }
                FillListView();
            }
        }

        private void SaveData()
        {
            using (var zip = new ZipFile(heroZip))
            {
                zip.Password = currentHashPassword;
                zip.RemoveEntry($"{Connection.CurrentUser.userid}.zip");
                zip.AddFile(userZip, "");
                zip.Save(heroZip);
            }
        }

        private void FillListView()
        {
            loadPictureBox.Visible = true;
            localFilesListView.Items.Clear();
            using (var Zip = new ZipFile(userZip))
            {
                foreach (var entry in Zip.Entries)
                {
                    localFilesListView.Items.Add(entry.FileName);
                }
            }
            loadPictureBox.Visible = false;
        }

        public MainForm()
        {
            InitializeComponent();
            if (Connection.CurrentUser.userid == "")
            {
                isOflline = true;
                Connection.CurrentUser = new User { userid = "LocalHeroData" };
                currentHashPassword = GetHash("localdb");
            }
            else
            {
                currentHashPassword = GetHash(Connection.CurrentUser.passwd);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Icon = HeroPecApp.Properties.Resources.iconmain;
            CheckDirectory();
            FillListView();
            textBox1.Text = currentHashPassword;
        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            AddFile();
            FillListView();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteFile();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
            File.Delete(userZip);
        }

        private void cloudLocalCheckBox_CheckedChanged(object sender)
        {
            cloudLocalCheckBox.Text = cloudLocalCheckBox.Checked ? "Облачное хранение" 
                : "Локальное хранение";

        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void wrapPictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximizePictureBox_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void dragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

        private void exitPictureBox_MouseHover(object sender, EventArgs e)
        {
            exitPictureBox.Image = Properties.Resources.exit_hover;
        }

        private void exitPictureBox_MouseLeave(object sender, EventArgs e)
        {
            exitPictureBox.Image = Properties.Resources.exit;
        }

        private void wrapPictureBox_MouseHover(object sender, EventArgs e)
        {
            wrapPictureBox.Image = Properties.Resources.minimize_hover;
        }

        private void wrapPictureBox_MouseLeave(object sender, EventArgs e)
        {
            wrapPictureBox.Image = Properties.Resources.wrap;
        }
    }
}

