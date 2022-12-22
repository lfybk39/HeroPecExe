using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroPecApp
{
    public partial class ConfigurationForm : Form
    {
        private Point windowPoint = new Point();

        public ConfigurationForm()
        {
            this.Icon = HeroPecApp.Properties.Resources.optionicon;
            InitializeComponent();
        }

        private void ChangeState(bool enabled)
        {
            string[] ctrls = { "exitPictureBox", "wrapPictureBox", "dragPanel" };
            foreach (Control control in Controls)
            {
                if (!ctrls.Contains(control.Name))
                {
                    control.Enabled = enabled;
                }
            }
            loadPictureBox.Enabled = loadPictureBox.Visible = !enabled;
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            folderTextBox.Texts = Properties.Settings.Default.LocalPath == ""
            ? $"{Environment.CurrentDirectory}\\DataFiles"
            : Properties.Settings.Default.LocalPath;
            passwordTextBox.Texts = Properties.Settings.Default.LocalAdminPassword;
            databaseTextBox.Texts = Properties.Settings.Default.Database;
            userIDTextBox.Texts = Properties.Settings.Default.DBUserID;
            userPasswordTextBox.Texts = Properties.Settings.Default.DBUserPassword;
            serverIPTextBox.Texts = Properties.Settings.Default.ServerIP;
            serverPortTextBox.Texts = Properties.Settings.Default.ServerPort.ToString();
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            ChangeState(false);
            await Task.Run(()=> Save());
            ChangeState(true);
        }

        private void Save()
        {
            StringBuilder errors = new StringBuilder();
            if (!Directory.Exists(folderTextBox.Texts))
            {
                errors.AppendLine("Указан неверный путь для локального хранения");
            }
            if (passwordTextBox.Texts.Trim().Length == 0)
            {
                errors.AppendLine("Пароль администратора не может быть пустым");
            }
            try
            {
                Properties.Settings.Default.Database = databaseTextBox.Texts;
                Properties.Settings.Default.DBUserID = userIDTextBox.Texts;
                Properties.Settings.Default.DBUserPassword = userPasswordTextBox.Texts;
                Properties.Settings.Default.ServerIP = serverIPTextBox.Texts;
                Properties.Settings.Default.ServerPort = uint.Parse(serverPortTextBox.Texts);
                Core.Context.User.ToList();
            }
            catch (Exception)
            {
                errors.AppendLine("Неверные данные для подключения БД");
            }
            if (errors.Length == 0)
            {
                Properties.Settings.Default.LocalPath = folderTextBox.Texts ==
                    $"{Environment.CurrentDirectory}\\DataFiles"
                    ? "" : folderTextBox.Texts;
                Properties.Settings.Default.LocalAdminPassword = passwordTextBox.Texts.Trim();
                Properties.Settings.Default.Save();
                HeroMessageBox.Show("Данные сохранены");
            }
            else
            {
                HeroMessageBox.Show(errors.ToString(), "Ошибка!");
            }
        }

        private void usersLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new ManageUsersForm().ShowDialog();
            this.Show();
        }

        private void folderPictureBox_Click(object sender, EventArgs e)
        {
            var folder = new FolderBrowserDialog();
            folder.SelectedPath = folderTextBox.Texts;
            if (folder.ShowDialog() == DialogResult.OK)
            {
                folderTextBox.Texts = folder.SelectedPath;
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

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            windowPoint = new Point(e.X, e.Y);
        }

        private void dragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - windowPoint.X, this.Location.Y + e.Y - windowPoint.Y);
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

        private void showPasswordToggleSwitch_CheckedChanged()
        {
            passwordTextBox.UseChar = !showPasswordToggleSwitch.Checked;
        }
    }
}
