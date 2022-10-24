﻿using System;
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
using HeroPecApp.Controls;
using HeroPecApp.Properties;

namespace HeroPecApp
{
    public partial class AuthorizationForm : Form
    {
        private Point windowPoint = new Point();

        private void ChangeState(bool enabled)
        {
            foreach(Control control in Controls)
            {
                control.Enabled = enabled;
            }
        }

        private async Task Authorize()
        {
            var currentUser = Core.Context.Users.AsNoTracking().FirstOrDefault(
            u => emailLoginTextBox.Texts.Contains("@") ? (u.Email == emailLoginTextBox.Texts)
            : (u.Login == emailLoginTextBox.Texts));
            if (currentUser == null || currentUser.Password != passwordTextBox.Texts)
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
        }

        private async Task AuthorizeAsync()
        {
            ChangeState(false);
            logoPictureBox.Image = Properties.Resources.logogif;
            await Task.Run(Authorize);
            logoPictureBox.Image = Properties.Resources.logo;
            ChangeState(true);
        }

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

        private async void authorizationButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (emailLoginTextBox.Texts != Properties.Settings.Default.LocalAdminLogin)
                {
                    await AuthorizeAsync();
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else if (passwordTextBox.Texts == Properties.Settings.Default.LocalAdminPassword)
                {
                    new ConfigurationForm().Show();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                logoPictureBox.Image = Properties.Resources.logo;
                ChangeState(true);
            }
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

        private void showPasswordCheckBox_CheckedChanged(object sender)
        {
            passwordTextBox.UseChar = !showPasswordCheckBox.Checked;
        }

        private void stayLoggedCheckBox_CheckedChanged(object sender)
        {
            Properties.Settings.Default.IsRemember = false;
            Properties.Settings.Default.Save();
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
    }

}
