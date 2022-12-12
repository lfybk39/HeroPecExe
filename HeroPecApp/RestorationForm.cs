using HeroPecApp.ConnectionFTP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HeroPecApp
{
    public partial class RestorationForm : Form
    {
        private int code = 0;
        private Point mPoint = new Point();
        private User currentUser = new User();

        private void ChangeState(bool enabled)
        {
            logoPictureBox.Image = enabled ? Properties.Resources.logo : Properties.Resources.logogif;
            foreach (Control control in Controls)
            {
                if (control.GetType().Name != "PictureBox")
                {
                    control.Enabled = enabled;
                }
            }
        }

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
            this.Icon = HeroPecApp.Properties.Resources.iconmain;
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (emailLoginTextBox.Texts.Contains("@") 
                ? (Regex.IsMatch(emailLoginTextBox.Texts.Trim(), @"^[-\w.]+@([A-z0-9][-A-z0-9]+\.)+[A-z]{2,4}$")) 
                : (Regex.IsMatch(emailLoginTextBox.Texts.Trim(), @"^[a-zA-Z0-9]{4,20}$")))
            {
                try
                {
                    currentUser = Core.Context.User.AsNoTracking().FirstOrDefault(
                        u => emailLoginTextBox.Texts.Contains("@") ? (u.email == emailLoginTextBox.Texts)
                        : (u.userid == emailLoginTextBox.Texts));
                    if (!(currentUser is null))
                    {
                        var random = new Random();
                        code = random.Next(1000, 9999);
                        SendEmail(code, currentUser.email);
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
            else
            {
                MessageBox.Show("Введите логин или E-mail");
            }
        }

        private void codeButton_Click(object sender, EventArgs e)
        {
            if (code.ToString() == codeTextBox.Texts)
            {
                codePanel.Visible = false;
                restorationPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("Неверный код");
            }
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(passwordTextBox.Texts, @"^[a-zA-Z0-9]{8,20}$") || passwordTextBox.Texts.Contains(" "))
                {
                    MessageBox.Show("Пожалуйста укажите корректный пароль. Пароль должен состоять из 8-20 символов, которые могут быть строчными и прописными латинского алфавита.");
                }
                else if (passwordTextBox.Texts == confirmationTextBox.Texts)
                {
                    Core.Context.User.FirstOrDefault(u => u.id == currentUser.id).passwd = passwordTextBox.Texts;
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

        private void showPasswordCheckBox_CheckedChanged(object sender)
        {
            passwordTextBox.UseChar = confirmationTextBox.UseChar = !showPasswordCheckBox.Checked;
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
    }
}
