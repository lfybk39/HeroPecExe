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
                if ((Core.Context.Users.Any(u => u.Login == user.Login) && !isEdit) || user.Login == Properties.Settings.Default.LocalAdminLogin)
                {
                    errors.AppendLine("Логин уже зарегистрирован в системе.");
                }
                else if (!Regex.IsMatch(user.Login.Trim(), @"^[a-zA-Z0-9]{4,20}$") || user.Login.Contains(" "))
                {
                    errors.AppendLine("Пожалуйста укажите корректный логин. Логин должен состоять из 4-20 символов, которые могут быть строчными и прописными латинского алфавита.");
                }
                if (!Regex.IsMatch(user.Password.Trim(), @"^[a-zA-Z0-9]{8,20}$") || user.Password.Contains(" "))
                {
                    errors.AppendLine("Пожалуйста укажите корректный пароль. Пароль должен состоять из 8-20 символов, которые могут быть строчными и прописными латинского алфавита.");
                }
                if ((Core.Context.Users.Any(u => u.Email == user.Email) && !isEdit) 
                    || (Core.Context.Users.Any(u => u.Email == user.Email && u.Login != user.Login) && isEdit))
                {
                    errors.AppendLine("E-mail уже зарегистрирован в системе.");
                }
                if (!Regex.IsMatch(user.Email.Trim(), @"^[-\w.]+@([A-z0-9][-A-z0-9]+\.)+[A-z]{2,4}$") || user.Email.Contains(" "))
                {
                    errors.AppendLine("Пожалуйста укажите корректный E-mail.");
                }
                if (errors.Length == 0)
                {
                    if (isEdit)
                    {
                        var editUser = Core.Context.Users.FirstOrDefault(u => u.Login == selectedUserLogin);
                        editUser.Login = user.Login;
                        editUser.Email = user.Email;
                        editUser.Password = user.Password;
                        editUser.Nickname = user.Nickname;
                        editUser.Phone = user.Phone;
                        Core.Context.SaveChanges();
                    }
                    else
                    {
                        Core.Context.Users.Add(user);
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
            this.selectedUserLogin = selectedUser.Login;
            confirmButton.Text = "Изменить пользователя";
            isEdit = true;
            loginTextBox.Text = selectedUser.Login;
            passwordTextBox.Text = selectedUser.Password;
            eMailTextBox.Text = selectedUser.Email;
            nicknameTextBox.Text = selectedUser.Nickname;
            phoneTextBox.Text = selectedUser.Phone;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            SaveUser(new User
            {
                Login = loginTextBox.Text,
                Email = eMailTextBox.Text,
                Password = passwordTextBox.Text,
                Nickname = nicknameTextBox.Text,
                Phone = phoneTextBox.Text == "+7 (   )       -" || phoneTextBox.Text.Trim() == "" ? null : phoneTextBox.Text
            });
        }
    }
}
