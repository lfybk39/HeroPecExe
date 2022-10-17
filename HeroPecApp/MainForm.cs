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
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace HeroPecApp
{
    public partial class MainForm : Form
    {
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
            //    if (!File.Exists($"{Environment.CurrentDirectory}\\DataFiles\\HeroData.zip"))
            //    {
            //        Directory.CreateDirectory($"{Environment.CurrentDirectory}\\DataFiles");
            //        using (ZipFile zip = new ZipFile())
            //        {
            //            zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression; // Задаем максимальную степень сжатия 
            //            zip.Password = Properties.Settings.Default.CurrentUserPassword;
            //            zip.AddFile(File.Create($"{Environment.CurrentDirectory}\\DataFiles\\{Properties.Settings.Default.CurrentUserLogin}.zip").Name, "");
            //            zip.Save($"{Environment.CurrentDirectory}\\DataFiles\\HeroData.zip");
            //        }
            //    }

            //    using (ZipFile zip = new ZipFile($"{Environment.CurrentDirectory}\\DataFiles\\HeroData.zip"))
            //    {
            //        foreach (var item in zip.Entries)
            //                filesListView.Items.Add(item.FileName);
            //    }
        }
    }
}
