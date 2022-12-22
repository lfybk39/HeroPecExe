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
using System.Runtime.Serialization;

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
        private ImageList icoImageList = new ImageList();

        private void ChangeState(bool enabled)
        {
            string[] ctrls = { "filesListView", "exitPictureBox", "wrapPictureBox", "dragPanel" };
            foreach (Control control in Controls)
            {
                if (!ctrls.Contains(control.Name))
                {
                    control.Enabled = enabled;
                }
            }
            cloudLocalToggleSwitch.Enabled = isOflline ? false : enabled;
            loadPictureBox.Enabled = loadPictureBox.Visible = !enabled;
        }

        public static string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        private int GetIcoIndex(string file)
        {
            switch (Path.GetExtension(file).ToLower().Replace(".", ""))
            {
                case "pdf":
                    return 1;

                case "jpg":
                case "png":
                case "jpeg":
                case "gif":
                case "bmp":
                    return 2;

                case "txt":
                case "text":
                    return 3;

                case "zip":
                case "rar":
                case "7z":
                    return 4;

                case "exe":
                    return 5;

                case "psd":
                    return 6;

                case "doc":
                case "docx":
                    return 7;

                default:
                    return 0;
            }
        }

        private void CheckDirectory()
        {
            if (!File.Exists(localZip))
            {
                Directory.CreateDirectory(localZip.Replace($"\\{Connection.CurrentUser.userid}.zip", ""));
                using (ZipFile zip = new ZipFile(Encoding.UTF8))
                {
                    zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                    zip.Password = currentHashPassword;
                    zip.Save(localZip);
                }
            }
        }

        private void AddFile(string[] files)
        {

            if (cloudLocalToggleSwitch.Checked)
            {
                foreach (var item in files)
                {
                    FtpHelper.UploadFile(item, address + "/" + Path.GetFileName(item), FtpUserid, Connection.CurrentUser.passwd);
                }
            }
            else
            {
                using (var zip = new ZipFile(localZip, Encoding.UTF8))
                {
                    zip.Password = currentHashPassword;
                    foreach (var item in files)
                    {
                        if (!zip.EntryFileNames.Contains(Path.GetFileName(item)))
                        {
                            zip.AddFile(item, "");
                        }
                        else if (HeroMessageBox.Show($"В базе уже есть файл:\n{item}\nЗаменить?", MessageBoxButtons.YesNo))
                        {
                            zip.RemoveEntry(Path.GetFileName(item));
                            zip.AddFile(item, "");
                        }
                    }
                    zip.Save(localZip);
                }
            }
            HeroMessageBox.Show($"Кол-во добавленных файлов: {files.Length}");
        }

        private void DeleteFile(ListViewItem[] selection)
        {
            if (HeroMessageBox.Show("Вы уверены, что хотите удалить файл?", MessageBoxButtons.YesNo))
            {
                if (cloudLocalToggleSwitch.Checked)
                {
                    foreach (ListViewItem item in selection)
                    {
                        FtpHelper.DeleteFile(address + "/" + item.Text, FtpUserid, Connection.CurrentUser.passwd);
                    }
                }
                else
                {
                    using (var zip = new ZipFile(localZip, Encoding.UTF8))
                    {
                        foreach (ListViewItem item in selection)
                        {
                            zip.Password = currentHashPassword;
                            zip.RemoveEntry(item.Text);
                            zip.Save(localZip);
                        }
                    }
                }
            }
            HeroMessageBox.Show($"Кол-во удаленных файлов: {selection.Length}");
        }

        private void ExtractFile(string path, ListViewItem[] selection)
        {

            if (cloudLocalToggleSwitch.Checked)
            {
                foreach (ListViewItem item in selection)
                {
                    FtpHelper.DownloadFile(Path.Combine(path, item.Text), address + "/" + item.Text, FtpUserid, Connection.CurrentUser.passwd);
                }
            }
            else
            {
                using (var zip = new ZipFile(localZip, Encoding.UTF8))
                {
                    foreach (ListViewItem item in selection)
                    {
                        var zipEntry = zip.SingleOrDefault(z => z.FileName == item.Text);
                        zipEntry.ExtractWithPassword(path, currentHashPassword);
                    }
                }
            }
            HeroMessageBox.Show($"Кол-во извлеченных файлов: {selection.Length}");
        }

        private ListViewItem[] FillListView()
        {
            if (cloudLocalToggleSwitch.Checked)
            {
                try
                {
                    var files = FtpHelper.GetFilesList(address, FtpUserid, Connection.CurrentUser.passwd).ToArray();
                    ListViewItem[] Files = new ListViewItem[files.Length];
                    for (int i = 0; i < files.Length; i++)
                    {
                        Files[i] = new ListViewItem(files[i], GetIcoIndex(files[i]));
                    }
                    return Files;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            else
            {
                CheckDirectory();
                using (var zip = new ZipFile(localZip, Encoding.UTF8))
                {
                    zip.AlternateEncodingUsage = ZipOption.Always;
                    zip.AlternateEncoding = Encoding.UTF8;
                    ListViewItem[] Files = new ListViewItem[zip.Entries.Count];
                    for (int i = 0; i < zip.Entries.Count; i++)
                    {
                        Files[i] = new ListViewItem(zip.Entries.ToArray()[i].FileName.ToString(),
                            GetIcoIndex(zip.Entries.ToArray()[i].FileName));
                    }
                    return Files;
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
            this.Icon = HeroPecApp.Properties.Resources.iconmain;
            cloudLocalToggleSwitch.Checked = false;
            icoImageList.Images.AddRange(new Image[]
            {
                Properties.Resources.HeroFile as Bitmap,
                Properties.Resources.HeroPDF as Bitmap,
                Properties.Resources.HeroPicture as Bitmap,
                Properties.Resources.HeroTXT as Bitmap,
                Properties.Resources.HeroZIP as Bitmap,
                Properties.Resources.HeroEXE as Bitmap,
                Properties.Resources.HeroPSD as Bitmap,
                Properties.Resources.HeroDoc as Bitmap
            });
            icoImageList.ImageSize = new Size(48, 48);
            filesListView.LargeImageList = icoImageList;

            if (Connection.CurrentUser is null)
            {
                isOflline = true;
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

        private async void MainForm_Load(object sender, EventArgs e)
        {
            ChangeState(false);
            filesListView.Items.AddRange(await Task.Run(() => FillListView()));
            ChangeState(true);
        }

        private async void addFileButton_Click(object sender, EventArgs e)
        {
            ChangeState(false);
            var addFile = new OpenFileDialog();
            addFile.Multiselect = true;
            if (addFile.ShowDialog() == DialogResult.OK)
            {
                await Task.Run(() => AddFile(addFile.FileNames));
                filesListView.Clear();
                filesListView.Items.AddRange(await Task.Run(() => FillListView()));
            }
            ChangeState(true);
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (filesListView.SelectedItems.Count > 0)
            {
                ChangeState(false);
                var selection = new ListViewItem[filesListView.SelectedItems.Count];
                for (int i = 0; i < filesListView.SelectedItems.Count; i++)
                {
                    selection[i] = filesListView.SelectedItems[i];
                }
                await Task.Run(() => DeleteFile(selection));
                filesListView.Clear();
                filesListView.Items.AddRange(await Task.Run(() => FillListView()));
                ChangeState(true);
            }
        }

        private async void extractFileButton_Click(object sender, EventArgs e)
        {
            if (filesListView.SelectedItems.Count > 0)
            {
                var extractionFolder = new FolderBrowserDialog();
                if (extractionFolder.ShowDialog() == DialogResult.OK)
                {
                    var selection = new ListViewItem[filesListView.SelectedItems.Count];
                    for (int i = 0; i < filesListView.SelectedItems.Count; i++)
                    {
                        selection[i] = filesListView.SelectedItems[i];
                    }
                    ChangeState(false);
                    await Task.Run(() => ExtractFile(extractionFolder.SelectedPath, selection));
                    ChangeState(true);
                }
            }
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

        private async void cloudLocalToggleSwitch_CheckedChanged()
        {
            cloudLocalToggleSwitch.Texts = cloudLocalToggleSwitch.Checked
                ? "Облачное хранилище"
                : "Локальное хранилище";
            ChangeState(false);
            filesListView.Clear();
            filesListView.Items.AddRange(await Task.Run(() => FillListView()));
            ChangeState(true);
        }

        private void backPictureBox_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void backPictureBox_MouseHover(object sender, EventArgs e)
        {
            backPictureBox.Image = Properties.Resources.HeroBackIcon_hover;
        }

        private void backPictureBox_MouseLeave(object sender, EventArgs e)
        {
            backPictureBox.Image = Properties.Resources.HeroBackIcon;
        }

        private async void refreshPictureBox_Click(object sender, EventArgs e)
        {
            ChangeState(false);
            filesListView.Items.AddRange(await Task.Run(() => FillListView()));
            ChangeState(true);
        }
    }
}

