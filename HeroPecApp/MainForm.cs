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

namespace HeroPecApp
{
    public partial class MainForm : Form
    {
        private static bool isOflline = false;
        private static User currentUser;
        private string currentHashPassword;
        private string userZip = $"{Environment.CurrentDirectory}\\TempData\\{currentUser.Login}.zip";
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
                zip.Entries.FirstOrDefault(en => en.FileName == $"{currentUser.Login}.zip").Extract($"{Environment.CurrentDirectory}\\TempData");
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
            if (filesListView.SelectedItems.Count != 0)
            {
                using (var zip = new ZipFile(userZip))
                {
                    foreach (ListViewItem item in filesListView.SelectedItems)
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
                zip.RemoveEntry($"{currentUser.Login}.zip");
                zip.AddFile(userZip, "");
                zip.Save(heroZip);
            }
        }

        private void FillListView()
        {
            loadPictureBox.Visible = true;
            filesListView.Items.Clear();
            using (var Zip = new ZipFile(userZip))
            {
                foreach (var entry in Zip.Entries)
                {
                    filesListView.Items.Add(entry.FileName);
                }
            }
            loadPictureBox.Visible = false;
        }

        public MainForm()
        {
            InitializeComponent();
            if (Properties.Settings.Default.CurrentUserLogin == "")
            {
                isOflline = true;
                currentUser = new User { Login = "LocalHeroData" };
                currentHashPassword = GetHash("localdb");
            }
            else
            {
                currentUser = Core.Context.Users.FirstOrDefault(u =>
                    Properties.Settings.Default.CurrentUserLogin.Contains("@") ?
                    u.Email == Properties.Settings.Default.CurrentUserLogin
                    : u.Login == Properties.Settings.Default.CurrentUserLogin);
                currentHashPassword = GetHash(currentUser.Password);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
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
    }
}
