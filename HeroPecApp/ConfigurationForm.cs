using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroPecApp
{
    public partial class ConfigurationForm : Form
    {
        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            folderTextBox.Text = Properties.Settings.Default.LocalPath == ""
            ? $"{Environment.CurrentDirectory}\\DataFiles"
            : Properties.Settings.Default.LocalPath;
            loginTextBox.Text = Properties.Settings.Default.LocalAdminLogin;
            passwordTextBox.Text = Properties.Settings.Default.LocalAdminPassword;
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            var folder = new FolderBrowserDialog();
            folder.SelectedPath = folderTextBox.Text;
            if(folder.ShowDialog() == DialogResult.OK)
            {
                folderTextBox.Text = folder.SelectedPath;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LocalPath = folderTextBox.Text == $"{Environment.CurrentDirectory}\\DataFiles" 
                ? "" : folderTextBox.Text;
            if(loginTextBox.Text.Trim().Length >= 8 && passwordTextBox.Text.Trim().Length >= 8)
            {
                Properties.Settings.Default.LocalAdminLogin = loginTextBox.Text.Trim();
                Properties.Settings.Default.LocalAdminPassword = passwordTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Логин и пароль должны иметь длину более 8 символов");
            }
            Properties.Settings.Default.Save();
            MessageBox.Show("Данные сохранены");
        }

        private void usersLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ManageUsersForm().Show();
        }
    }
}
