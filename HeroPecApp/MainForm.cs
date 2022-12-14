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
        private string address = "ftp://91.122.211.144:50021";
        private string FtpUserid;
        private Point mPoint = new Point();
        private static bool isOflline = false;
        private string currentHashPassword;
        private string localZip;

        public static string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        private void CheckDirectory()
        {
            if (!File.Exists(localZip))
            {
                Directory.CreateDirectory(localZip.Replace($"\\{Connection.CurrentUser.userid}.zip", ""));
                using (ZipFile zip = new ZipFile())
                {
                    zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                    zip.Password = currentHashPassword;
                    zip.Save(localZip);
                }
            }
        }

        private void AddFile()
        {
            var addFile = new OpenFileDialog();
            addFile.Multiselect = true;
            if (addFile.ShowDialog() == DialogResult.OK)
            {
                if (cloudLocalCheckBox.Checked)
                {
                    foreach (var item in addFile.FileNames)
                    {
                        FtpHelper.UploadFile(item, address + "/" + Path.GetFileName(item), FtpUserid, Connection.CurrentUser.passwd);
                    }
                }
                else
                {
                    loadPictureBox.Visible = true;

                    using (var zip = new ZipFile(localZip))
                    {
                        zip.Password = currentHashPassword;
                        foreach (var item in addFile.FileNames)
                        {
                            zip.AddFile(item, "");
                        }
                        zip.Save(localZip);
                    }

                    loadPictureBox.Visible = false;
                }
                FillListView();
            }
        }

        private void DeleteFile()
        {
            if (HeroMessageBox.Show("Вы уверены, что хотите удалить файл?", MessageBoxButtons.YesNo))
            {
                if (cloudLocalCheckBox.Checked)
                {
                    foreach (ListViewItem item in filesListView.SelectedItems)
                    {
                        FtpHelper.DeleteFile(address + "/" + item.Text, FtpUserid, Connection.CurrentUser.passwd);
                    }
                }
                else
                {
                    if (filesListView.SelectedItems.Count != 0)
                    {
                        using (var zip = new ZipFile(localZip))
                        {
                            foreach (ListViewItem item in filesListView.SelectedItems)
                            {
                                zip.Password = currentHashPassword;
                                zip.RemoveEntry(item.Text);
                                zip.Save(localZip);
                            }
                        }
                    }
                }
                FillListView();
            }
        }

        private void ExtractFile()
        {
            var extractionFolder = new FolderBrowserDialog();
            if (extractionFolder.ShowDialog() == DialogResult.OK)
            {
                if (cloudLocalCheckBox.Checked)
                {
                    foreach (ListViewItem item in filesListView.SelectedItems)
                    {
                        FtpHelper.DownloadFile(Path.Combine(extractionFolder.SelectedPath, item.Text), address + "/" + item.Text, FtpUserid, Connection.CurrentUser.passwd);
                    }
                }
                else
                {
                    if (filesListView.SelectedItems.Count != 0)
                    {
                        using (var zip = new ZipFile(localZip))
                        {
                            foreach (ListViewItem item in filesListView.SelectedItems)
                            {
                                var zipEntry = zip.SingleOrDefault(z => z.FileName == item.Text);
                                zipEntry.ExtractWithPassword(extractionFolder.SelectedPath, currentHashPassword);
                            }
                        }
                    }
                }
                FillListView();
            }
        }

        private void FillListView()
        {
            if (cloudLocalCheckBox.Checked)
            {
                try
                {
                    List<string> Files = FtpHelper.GetFilesList(address, FtpUserid, Connection.CurrentUser.passwd);
                    filesListView.Items.Clear();
                    foreach (string File in Files)
                    {
                        filesListView.Items.Add(File);
                    }
                }
                catch (Exception)
                {

                }
            }
            else
            {
                CheckDirectory();
                loadPictureBox.Visible = true;
                filesListView.Items.Clear();
                using (var Zip = new ZipFile(localZip))
                {
                    foreach (var entry in Zip.Entries)
                    {
                        filesListView.Items.Add(entry.FileName);
                    }
                }
                loadPictureBox.Visible = false;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            this.Icon = HeroPecApp.Properties.Resources.iconmain;
            if (Connection.CurrentUser is null)
            {
                isOflline = true;
                cloudLocalCheckBox.Enabled = false;
                Connection.CurrentUser = new User { userid = "LocalHeroData" };
                localZip = (Properties.Settings.Default.LocalPath == ""
                    ? $"{Environment.CurrentDirectory}\\DataFiles"
                    : $"{Properties.Settings.Default.LocalPath}\\DataFiles") + $"\\{Connection.CurrentUser.userid}.zip";
                currentHashPassword = GetHash("localdb");
            }
            else
            {
                localZip = (Properties.Settings.Default.LocalPath == ""
                    ? $"{Environment.CurrentDirectory}\\DataFiles\\Users"
                    : $"{Properties.Settings.Default.LocalPath}\\DataFiles\\Users") + $"\\{Connection.CurrentUser.userid}.zip";
                currentHashPassword = GetHash(Connection.CurrentUser.passwd);
                FtpUserid = Connection.CurrentUser.userid + $".{Properties.Settings.Default.DBUserPassword}";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillListView();
        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            AddFile();
            FillListView();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(filesListView.SelectedItems.Count>0)
            {
                DeleteFile();
            }
        }

        private void extractFileButton_Click(object sender, EventArgs e)
        {
            if (filesListView.SelectedItems.Count > 0)
            {
                ExtractFile();
            }
        }

        private void cloudLocalCheckBox_CheckedChanged(object sender)
        {
            cloudLocalCheckBox.Text = cloudLocalCheckBox.Checked ? "Облачное хранение"
                : "Локальное хранение";
            FillListView();
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

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void wrapPictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

