using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HeroPecApp
{
    public partial class RestorationForm : Form
    {
        private int code = 0;
        private User currentUser = new User();
        private static void SendEmail(int code, string email)
        {
            using (var smtp = new SmtpClient())
            {
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential
                {
                    Password = Properties.Settings.Default.GoogleMailPassword,
                    UserName = Properties.Settings.Default.GoogleMailName
                };
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;

                var msg = new MailMessage()
                {
                    Subject = email,
                    Body = code.ToString(),
                    From = new MailAddress("heropeccompany@gmail.com"),
                    IsBodyHtml = true,
                    BodyEncoding = Encoding.UTF8
                };

                msg.To.Add(new MailAddress(email));

                smtp.Send(msg);
            }
        }

        public RestorationForm()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                currentUser = Core.Context.Users.AsNoTracking().FirstOrDefault(
                    u => emailLoginTextBox.Text.Contains("@") ? (u.Email == emailLoginTextBox.Text)
                    : (u.Login == emailLoginTextBox.Text));
                if (!(currentUser is null))
                {
                    var random = new Random();
                    code = random.Next(1000, 9999);
                    SendEmail(code, currentUser.Email);
                    MessageBox.Show($"На ваш почтовый ящик отправлен код подтверждения");
                    codeButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void codeButton_Click(object sender, EventArgs e)
        {
            if (code.ToString() == codeTextBox.Text)
            {
                label1.Visible = label2.Visible = emailLoginTextBox.Visible = codeTextBox.Visible = confirmButton.Visible = codeButton.Visible = false;
                label3.Visible = label4.Visible = passwordTextBox.Visible = confirmationTextBox.Visible = showPassCheckBox.Visible = restoreButton.Visible = true;
            }
            else
            {
                MessageBox.Show("Неверный код");
            }
        }

        private void showPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = confirmationTextBox.UseSystemPasswordChar = !showPassCheckBox.Checked;
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(passwordTextBox.Text, @"^[a-zA-Z0-9]{8,20}$") || passwordTextBox.Text.Contains(" "))
                {
                    MessageBox.Show("Пожалуйста укажите корректный пароль. Пароль должен состоять из 8-20 символов, которые могут быть строчными и прописными латинского алфавита.");
                }
                else if (passwordTextBox.Text == confirmationTextBox.Text)
                {
                    Core.Context.Users.FirstOrDefault(u => u.IdUser == currentUser.IdUser).Password = passwordTextBox.Text;
                    Core.Context.SaveChanges();
                    MessageBox.Show("Пароль успешно изменён");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
