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
using System.Threading.Tasks;
using System.Windows.Forms;
using HeroPecApp.ConnectionFTP;
using HeroPecApp.Controls;
using HeroPecApp.Properties;

namespace HeroPecApp
{
    public partial class AuthorizationForm : Form
    {
        private Point windowPoint = new Point();

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

        private async Task Authorize()
        {
            try
            {
                var currentUser = Core.Context.User.AsNoTracking().FirstOrDefault(
                u => emailLoginTextBox.Texts.Contains("@") ? (u.email == emailLoginTextBox.Texts)
                : (u.userid == emailLoginTextBox.Texts));
                if (currentUser == null || currentUser.passwd != passwordTextBox.Texts)
                {
                    throw new Exception("Неверные данные для входа.");
                }
                SendEmail(currentUser);
                HeroMessageBox.Show($"{currentUser.userid}, вы успешно авторизовались!");
                Connection.CurrentUser = currentUser;
                Properties.Settings.Default.CurrentUserLogin = currentUser.userid;
                Properties.Settings.Default.CurrentUserPassword = currentUser.passwd;
                if (stayLoggedToggleSwitch.Checked)
                {
                    Properties.Settings.Default.IsRemember = true;
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private async Task<bool> AuthorizeAsync()
        {
            bool authorized = false;
            ChangeState(false);
            try
            {
                await Task.Run(Authorize);
                authorized = true;
            }
            catch (Exception ex)
            {
                HeroMessageBox.Show(ex.Message);
            }
            ChangeState(true);
            return authorized;
        }

        private static void SendEmail(User currentUser)
        {
            using (var smtp = new SmtpClient())
            {
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential
                {
                    Password = "ioboqiqrrhxhkgfi",
                    UserName = "heropecgroup@gmail.com"
                };
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;

                var msg = new MailMessage()
                {
                    Subject = "Вход в приложение HeroPeC",
                    Body = MailHelper.Authorization(currentUser.userid),
                    From = new MailAddress("heropeccompany@gmail.com"),
                    IsBodyHtml = true,
                    BodyEncoding = Encoding.UTF8
                };

                msg.To.Add(new MailAddress(currentUser.email));

                smtp.Send(msg);
            }
        }

        public AuthorizationForm()
        {
            this.Icon = HeroPecApp.Properties.Resources.iconmain;
            var intro = new IntroForm();
            intro.Show();
            //if (Properties.Settings.Default.IsRemember == true)
            //{
            //    stayLoggedToggleSwitch.Checked = true;
            //    emailLoginTextBox.Texts = Properties.Settings.Default.CurrentUserLogin;
            //    passwordTextBox.Texts = Properties.Settings.Default.CurrentUserPassword;
            //}
            InitializeComponent();
            if (Properties.Settings.Default.IsRemember == true)
            {
                stayLoggedToggleSwitch.Checked = true;
                emailLoginTextBox.Texts = Properties.Settings.Default.CurrentUserLogin;
                passwordTextBox.Texts = Properties.Settings.Default.CurrentUserPassword;
            }
            intro.Close();
        }

        private async void authorizationButton_Click(object sender, EventArgs e)
        {
            if (!offlineModeToggleSwitch.Checked)
            {
                if (emailLoginTextBox.Texts.Trim().Length > 3
                    && passwordTextBox.Texts.Trim().Length > 7)
                {
                    try
                    {
                        if (await AuthorizeAsync())
                        {
                            this.DialogResult = DialogResult.OK;
                            Close();
                        }
                    }
                    catch (Exception exc)
                    {
                        HeroMessageBox.Show(exc.Message, "Ошибка!");
                    }
                    ChangeState(true);
                }
                else
                {
                    HeroMessageBox.Show("Заполните поля ввода");
                }
            }
            else
            {
                Properties.Settings.Default.CurrentUserLogin = "";
                DialogResult = DialogResult.OK;
            }
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new RegistrationForm().ShowDialog();
            this.Show();
        }

        private void restoreLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new RestorationForm().ShowDialog();
            this.Show();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {

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

        private void configurationPictureBox_Click(object sender, EventArgs e)
        {
            Hide();
            if (new AuthorizeAdminForm().ShowDialog() == DialogResult.OK)
            {
                new ConfigurationForm().ShowDialog();
            }
            Show();
        }

        private void showPassHeroToggleSwitch_Click(object sender, EventArgs e)
        {

        }

        private void stayLoggedToggleSwitch_Click(object sender, EventArgs e)
        { }

        private void offlineModeToggleSwitch_Click(object sender, EventArgs e)
        { }

        private void showPasswordToggleSwitch_CheckedChanged()
        {
            passwordTextBox.UseChar = !showPasswordToggleSwitch.Checked;
        }

        private void stayLoggedToggleSwitch_CheckedChanged()
        {
            Properties.Settings.Default.IsRemember = false;
            Properties.Settings.Default.Save();
        }

        private void offlineModeToggleSwitch_CheckedChanged()
        {
            showPasswordToggleSwitch.Enabled = stayLoggedToggleSwitch.Enabled
                = emailLoginTextBox.Enabled = passwordTextBox.Enabled = !offlineModeToggleSwitch.Checked;
        }

        private void infoPictureBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($@"{Environment.CurrentDirectory}\HeroPecInfo.pdf");
        }
    }
}
