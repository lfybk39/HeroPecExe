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
        private static string currentUserLogin = Core.Context.Users.FirstOrDefault(u => Properties.Settings.Default.CurrentUserLogin.Contains("@") ?
        u.Email == Properties.Settings.Default.CurrentUserLogin
        : u.Login == Properties.Settings.Default.CurrentUserLogin).Login;
        private string currentUserPassword = GetHash(Properties.Settings.Default.CurrentUserPassword);
        private string userZip = $"{Environment.CurrentDirectory}\\TempData\\{currentUserLogin}.zip";
        private string heroZip = $"{Environment.CurrentDirectory}\\DataFiles\\HeroData.zip";

        public static string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
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

        private void SaveData()
        {
            using (var zip = new ZipFile(heroZip))
            {
                zip.Password = currentUserPassword;
                zip.RemoveEntry($"{currentUserLogin}.zip");
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

            //if (new AuthorizationForm().ShowDialog() != DialogResult.OK)
            //{
            //    Close();
            //}
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(heroZip))
            {
                Directory.CreateDirectory($"{Environment.CurrentDirectory}\\DataFiles");
                using (ZipFile zip = new ZipFile())
                {
                    zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression; // Задаем максимальную степень сжатия 
                    zip.Save(userZip);
                    zip.Password = currentUserPassword;
                    zip.AddFile(userZip, "");
                    zip.Save($"{Environment.CurrentDirectory}\\DataFiles\\HeroData.zip");
                }
            }

            using (ZipFile zip = new ZipFile(heroZip))
            {
                zip.Password = currentUserPassword;
                if (File.Exists(userZip))
                {
                    File.Delete(userZip);
                }
                zip.Entries.FirstOrDefault(en => en.FileName == $"{currentUserLogin}.zip").Extract($"{Environment.CurrentDirectory}\\TempData");
            }
            FillListView();
            textBox1.Text = currentUserPassword;
        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            AddFile();
            FillListView();
        }

        private void deleteButton_Click(object sender, EventArgs e)
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
            File.Delete(userZip);
        }
    }
}
