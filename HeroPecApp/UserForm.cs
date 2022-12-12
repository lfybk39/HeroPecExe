using HeroPecApp.ConnectionFTP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroPecApp
{
    public partial class UserForm : Form
    {
        private bool isEdit = false;
        private Point mPoint = new Point();
        private string selectedUserLogin;

        void SaveUser(User user)
        {
            try
            {
                StringBuilder errors = new StringBuilder();
                if ((Core.Context.User.Any(u => u.userid == user.userid) && !isEdit) || user.userid == Properties.Settings.Default.LocalAdminLogin)
                {
                    errors.AppendLine("Логин уже зарегистрирован в системе.");
                }
                else if (!Regex.IsMatch(user.userid.Trim(), @"^[a-zA-Z0-9]{4,20}$") || user.userid.Contains(" "))
                {
                    errors.AppendLine("Пожалуйста укажите корректный логин. Логин должен состоять из 4-20 символов, которые могут быть строчными и прописными латинского алфавита.");
                }
                if (!Regex.IsMatch(user.passwd.Trim(), @"^[a-zA-Z0-9]{8,20}$") || user.passwd.Contains(" "))
                {
                    errors.AppendLine("Пожалуйста укажите корректный пароль. Пароль должен состоять из 8-20 символов, которые могут быть строчными и прописными латинского алфавита.");
                }
                if ((Core.Context.User.Any(u => u.email == user.email) && !isEdit) 
                    || (Core.Context.User.Any(u => u.email == user.email && u.userid != user.userid) && isEdit))
                {
                    errors.AppendLine("E-mail уже зарегистрирован в системе.");
                }
                if (!Regex.IsMatch(user.email.Trim(), @"^[-\w.]+@([A-z0-9][-A-z0-9]+\.)+[A-z]{2,4}$") || user.email.Contains(" "))
                {
                    errors.AppendLine("Пожалуйста укажите корректный E-mail.");
                }
                if (errors.Length == 0)
                {
                    if (isEdit)
                    {
                        var editUser = Core.Context.User.FirstOrDefault(u => u.userid == selectedUserLogin);
                        editUser.userid = user.userid;
                        editUser.email = user.email;
                        editUser.passwd = user.passwd;
                        editUser.username = user.username;
                        editUser.phone = user.phone;
                        Core.Context.SaveChanges();
                    }
                    else
                    {
                        Core.Context.User.Add(user);
                        Core.Context.SaveChanges();
                    }
                    MessageBox.Show("Успешно!");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show(errors.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public UserForm()
        {
            InitializeComponent();
        }

        public UserForm(User selectedUser)
        {
            InitializeComponent();
            this.selectedUserLogin = selectedUser.userid;
            confirmButton.Text = "Изменить пользователя";
            isEdit = true;
            loginTextBox.Texts = selectedUser.userid;
            passwordTextBox.Texts = selectedUser.passwd;
            eMailTextBox.Texts = selectedUser.email;
            nicknameTextBox.Texts = selectedUser.username;
            phoneTextBox.Texts = selectedUser.phone;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            SaveUser(new User
            {
                userid = loginTextBox.Texts,
                email = eMailTextBox.Texts,
                passwd = passwordTextBox.Texts,
                username = nicknameTextBox.Texts,
                phone = phoneTextBox.Texts == "+7 (   )       -" || phoneTextBox.Texts.Trim() == "" ? null : phoneTextBox.Texts
            });
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
