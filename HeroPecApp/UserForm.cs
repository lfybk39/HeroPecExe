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
            loginTextBox.Text = selectedUser.userid;
            passwordTextBox.Text = selectedUser.passwd;
            eMailTextBox.Text = selectedUser.email;
            nicknameTextBox.Text = selectedUser.username;
            phoneTextBox.Text = selectedUser.phone;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            SaveUser(new User
            {
                userid = loginTextBox.Text,
                email = eMailTextBox.Text,
                passwd = passwordTextBox.Text,
                username = nicknameTextBox.Text,
                phone = phoneTextBox.Text == "+7 (   )       -" || phoneTextBox.Text.Trim() == "" ? null : phoneTextBox.Text
            });
        }

    }
}
