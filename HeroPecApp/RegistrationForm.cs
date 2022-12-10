using HeroPecApp.ConnectionFTP;
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
    public partial class RegistrationForm : Form
    {
        private string captchaValue = String.Empty;

        private int passwordDifficulty = 0;

        private Point mPoint = new Point();

        private void CheckDifficulty(string password)
        {
            passwordDifficulty = 0;
            int length = 0;
            bool containsUpperLetter = false,
                containsLowerLetter = false,
                containsDigit = false;
            foreach (var c in password)
            {
                if (Char.IsLetter(c) && Char.IsUpper(c) && containsUpperLetter == false)
                {
                    containsUpperLetter = true;
                    passwordDifficulty++;
                }
                if (Char.IsLetter(c) && Char.IsLower(c) && containsLowerLetter == false)
                {
                    containsLowerLetter = true;
                    passwordDifficulty++;
                }
                if (Char.IsDigit(c) && containsDigit == false)
                {
                    containsDigit = true;
                    passwordDifficulty++;
                }
                length++;
            }
            if (length < 8)
            {
                passwordDifficulty = 0;
            }
        }

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = Width / 2 - 70;
            int Ypos = Height / 2 - 25;


            Brush[] colors = { Brushes.Red, Brushes.Blue, Brushes.Green };

            //Укажем где рисовать
            Graphics g = Graphics.FromImage((Image)result);

            //Пусть фон картинки будет серым
            g.Clear(Color.Black);

            //Сгенерируем текст
            captchaValue = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                captchaValue += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            g.DrawString(captchaValue,
                         new Font("Impact", 30),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            //Добавим немного помех
            /////Линии из углов
            g.DrawLine(Pens.Blue,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Blue,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            ////Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 8 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
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
                    Subject = "Регистрация HeroPeC",
                    Body = $"<p>Вы успешно зарегистрировались в HeroPeC!!</p>" +
                    $"<p>Ваш логин:{currentUser.userid}</p>" +
                    $"<p>Ваш пароль:{currentUser.passwd}</p>" +
                    $"<img src='http://tiny.cc/mmhzuz'>",
                    From = new MailAddress("heropeccompany@gmail.com"),
                    IsBodyHtml = true,
                    BodyEncoding = Encoding.UTF8
                };

                msg.To.Add(new MailAddress(currentUser.email));

                smtp.Send(msg);
            }
        }

        public void Registration(User user)
        {
            try
            {
                //SendEmail(new User { Login="YaViblyadok2009", Password="zZVv", Email= "pcs.91.akt@gmail.com" });
                //MessageBox.Show("Test");
                StringBuilder errors = new StringBuilder();
                if (Core.Context.User.Any(u => u.userid == user.userid) || user.userid == Properties.Settings.Default.LocalAdminLogin)
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
                if (Core.Context.User.Any(u => u.email == user.email))
                {
                    errors.AppendLine("E-mail уже зарегистрирован в системе.");
                }
                if (!Regex.IsMatch(user.email.Trim(), @"^[-\w.]+@([A-z0-9][-A-z0-9]+\.)+[A-z]{2,4}$") || user.email.Contains(" "))
                {
                    errors.AppendLine("Пожалуйста укажите корректный E-mail.");
                }
                if (passwordTextBox.Texts != confirmationPasswordTextBox.Texts)
                {
                    errors.AppendLine("Введеные пароли не совпадают.");
                }
                if (errors.Length == 0)
                {
                    if (captchaTextBox.Texts.ToLower() == captchaValue.ToLower())
                    {
                        Core.Context.User.Add(user);
                        Core.Context.SaveChanges();
                        MessageBox.Show($"{loginTextBox.Texts}, вы успешно зарегистрированы!");
                        SendEmail(user);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Неверная капча");
                    }
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

        public RegistrationForm()
        {
            InitializeComponent();
            errorEmailTextBox.Visible = false;
            errorLoginTextBox.Visible = false;
            errorConfirmPasswordLabel.Visible = false;
            errorPasswordLabel.Visible = false;

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                userid = loginTextBox.Texts,
                email = emailTextBox.Texts,
                passwd = passwordTextBox.Texts,
                username = nicknameTextBox.Texts.Trim() == "" ? null : nicknameTextBox.Texts,
                phone = phoneTextBox.Texts == "+7 (   )       -" ? null : phoneTextBox.Texts
            };
            if (passwordDifficulty < 2)
            {
                MessageBox.Show("Слабый пароль");
            }
            else
            {
                Registration(user);
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            this.Icon = HeroPecApp.Properties.Resources.iconmain;
            captchaPictureBox.Image = CreateImage(captchaPictureBox.Width, captchaPictureBox.Height);
        }

        private void changeCaptchaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            captchaPictureBox.Image = CreateImage(captchaPictureBox.Width, captchaPictureBox.Height);
        }

        private void refreshCaptchaPictureBox_Click(object sender, EventArgs e)
        {
            captchaPictureBox.Image = CreateImage(captchaPictureBox.Width, captchaPictureBox.Height);
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void wrapPictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximizePictureBox_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void exitPictureBox_MouseHover(object sender, EventArgs e)
        {
            exitPictureBox.Image = Properties.Resources.exit_hover;
        }

        private void exitPictureBox_MouseLeave(object sender, EventArgs e)
        {
            exitPictureBox.Image = Properties.Resources.exit;
        }

        private void maximizePictureBox_MouseHover(object sender, EventArgs e)
        {
            maximizePictureBox.Image = Properties.Resources.maximize_hover;
        }

        private void maximizePictureBox_MouseLeave(object sender, EventArgs e)
        {
            maximizePictureBox.Image = Properties.Resources.maximize;
        }

        private void wrapPictureBox_MouseHover(object sender, EventArgs e)
        {
            wrapPictureBox.Image = Properties.Resources.minimize_hover;
        }

        private void wrapPictureBox_MouseLeave(object sender, EventArgs e)
        {
            wrapPictureBox.Image = Properties.Resources.wrap;
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(emailTextBox.Texts.Trim(), @"^[-\w.]+@([A-z0-9][-A-z0-9]+\.)+[A-z]{2,4}$"))
            {
                emailLabel.ForeColor = Color.FromArgb(255, 77, 255, 186);
                errorEmailTextBox.Visible = false;
            }
            else
            {
                emailLabel.ForeColor = Color.Red;
                errorEmailTextBox.Visible = true;
            }
        }

        private void loginTextBox_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(loginTextBox.Texts.Trim(), @"^[a-zA-Z0-9]{4,20}$"))
            {
                loginLabel.ForeColor = Color.FromArgb(255, 77, 255, 186);
                errorLoginTextBox.Visible = false;
            }
            else
            {
                loginLabel.ForeColor = Color.Red;
                errorLoginTextBox.Visible = true;
            }
        }

        /*ВО ГРИШАНЯЯ ВОТ ТУТА ПОРАБОТАТЬ НАДО ЧТОБЫ ЧЕРКАШ ПОД ТЕКСТБОКСАМ ПАРОЛА ЦВЕТ
         * МЕНЯЛ ОТ СЛОЖНОСТИ И ЧТБЫЭ ПИСАЛО СЛОЖНЫЙ ЧИ НЕ
         *                                   .-.
                (___________________________()6 `-,
                (   ______________________   /''"`
                //\\                      //\\
                "" ""                     "" ""
        */
        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(passwordTextBox.Texts.Trim(), @"^[a-zA-Z0-9]{8,20}$"))
            {
                passwordLabel.ForeColor = Color.FromArgb(255, 77, 255, 186);
                errorPasswordLabel.Visible = false;
                CheckDifficulty(passwordTextBox.Texts);
                if (passwordDifficulty == 1)
                {
                    passwordLabel.ForeColor = Color.Red;
                    passDifficultyLabel.Visible = true;
                    passDifficultyLabel.Text = "Слабый пароль";
                }
                else if (passwordDifficulty == 2)
                {
                    passwordLabel.ForeColor = Color.Yellow;
                    passDifficultyLabel.Visible = true;
                    passDifficultyLabel.Text = "Средний пароль";
                }
                else
                {
                    passwordLabel.ForeColor = Color.Green;
                    passDifficultyLabel.Visible = true;
                    passDifficultyLabel.Text = "Сильный пароль";
                }
            }
            else
            {
                passDifficultyLabel.Visible = false;
                passwordLabel.ForeColor = Color.Red;
                errorPasswordLabel.Visible = true;
            }
        }

        private void confirmationPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Texts != confirmationPasswordTextBox.Texts)
            {
                passwordLabel.ForeColor = Color.Red;
                confirmPasswordLabel.ForeColor = Color.Red;
                errorConfirmPasswordLabel.Visible = true;
            }
            else
            {
                passwordLabel.ForeColor = Color.FromArgb(255, 77, 255, 186);
                confirmPasswordLabel.ForeColor = Color.FromArgb(255, 77, 255, 186);
                errorConfirmPasswordLabel.Visible = false;
            }
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
