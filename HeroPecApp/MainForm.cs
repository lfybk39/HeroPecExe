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

namespace HeroPecApp
{
    public partial class MainForm : Form
    {
        private string userZip = $"{Environment.CurrentDirectory}\\TempData\\{Properties.Settings.Default.CurrentUserLogin}.zip";
        private string heroZip = $"{Environment.CurrentDirectory}\\DataFiles\\HeroData.zip";

        private void FillListView()
        {
            filesListView.Items.Clear();
            using (var Zip = new ZipFile(userZip))
            {
                foreach (var entry in Zip.Entries)
                {
                    filesListView.Items.Add(entry.FileName);
                }
            }
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
                    zip.Password = Properties.Settings.Default.CurrentUserPassword;
                    zip.AddFile(userZip, "");
                    zip.Save($"{Environment.CurrentDirectory}\\DataFiles\\HeroData.zip");
                }
            }

            using (ZipFile zip = new ZipFile(heroZip))
            {
                zip.Password = Properties.Settings.Default.CurrentUserPassword;
                if (File.Exists(userZip))
                {
                    File.Delete(userZip);
                }
                zip.Entries.FirstOrDefault(en => en.FileName == $"{Properties.Settings.Default.CurrentUserLogin}.zip").Extract($"{Environment.CurrentDirectory}\\TempData");
            }
            FillListView();
        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            var addFile = new OpenFileDialog();
            if(addFile.ShowDialog() == DialogResult.OK)
            {
                using (var zip = new ZipFile(userZip))
                {
                    zip.AddFile(addFile.FileName, "");
                    zip.Save(userZip);
                }
            }
            FillListView();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var zip = new ZipFile(heroZip))
                {
                    zip.Password = Properties.Settings.Default.CurrentUserPassword;
                    zip.RemoveEntry($"{Properties.Settings.Default.CurrentUserLogin}.zip");
                    zip.AddFile(userZip, "");
                    zip.Save(heroZip);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
