using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeroPecApp.Controls;
using HeroPecApp.Properties;

namespace HeroPecApp
{
    public partial class AuthorizationForm : Form
    {
        private static void SendEmail(User currentUser)
        {
            using (var smtp = new SmtpClient())
            {
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential
                {
                    Password = "yrzsdlzcdivsdpcd",
                    UserName = "heropeccompany@gmail.com"
                };
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;

                var msg = new MailMessage()
                {
                    Subject = "Вход в приложение HeroPeC",
                    Body = $"<p>Совершен вход в аккаунт:{currentUser.Login}</p>" +
                    $"<p>Если это не вы, смените пароль</p>",
                    From = new MailAddress("heropeccompany@gmail.com"),
                    IsBodyHtml = true,
                    BodyEncoding = Encoding.UTF8
                };

                msg.To.Add(new MailAddress(currentUser.Email));

                smtp.Send(msg);
            }
        }

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void authorizationButton_Click(object sender, EventArgs e)
        {
            try
            {
                var currentUser = Core.Context.Users.AsNoTracking().FirstOrDefault(
                    u => emailLoginTextBox.Text.Contains("@") ? (u.Email == emailLoginTextBox.Text)
                    : (u.Login == emailLoginTextBox.Text));
                if (currentUser == null || currentUser.Password != passwordTextBox.Text)
                {
                    throw new Exception("Неверные данные для входа.");
                }
                //SendEmail(currentUser);
                MessageBox.Show("Вы успешно авторизовались!", "Успешный вход!", MessageBoxButtons.OK);
                Properties.Settings.Default.CurrentUserLogin = currentUser.Login;
                Properties.Settings.Default.CurrentUserPassword = currentUser.Password;
                if (stayLoggedCheckBox.Checked)
                {                    
                    Properties.Settings.Default.IsRemember = true;
                    Properties.Settings.Default.Save();
                }
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPasswordCheckBox.Checked;
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegistrationForm().Show();
        }

        private void restoreLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RestorationForm().Show();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.IsRemember == true)
            {
                stayLoggedCheckBox.Checked = true;
                emailLoginTextBox.Text = Properties.Settings.Default.CurrentUserLogin;
                passwordTextBox.Text = Properties.Settings.Default.CurrentUserPassword;
            }
        }

        private void stayLoggedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.IsRemember = false;
            Properties.Settings.Default.Save();
        }
    }
}
