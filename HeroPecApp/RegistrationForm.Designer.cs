
namespace HeroPecApp
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.emailLabel = new System.Windows.Forms.Label();
            this.registrationButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.captchaLabel = new System.Windows.Forms.Label();
            this.wrapPictureBox = new System.Windows.Forms.PictureBox();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.refreshCaptchaPictureBox = new System.Windows.Forms.PictureBox();
            this.captchaPictureBox = new System.Windows.Forms.PictureBox();
            this.errorEmailLabel = new System.Windows.Forms.Label();
            this.errorLoginLabel = new System.Windows.Forms.Label();
            this.errorPasswordLabel = new System.Windows.Forms.Label();
            this.errorConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.dragPanel = new System.Windows.Forms.PictureBox();
            this.loadPictureBox = new System.Windows.Forms.PictureBox();
            this.passwordDifficultyLabel = new System.Windows.Forms.Label();
            this.infoPictureBox = new System.Windows.Forms.PictureBox();
            this.captchaTextBox = new HeroPecApp.Controls.TextBoxControl();
            this.confirmationPasswordTextBox = new HeroPecApp.Controls.TextBoxControl();
            this.passwordTextBox = new HeroPecApp.Controls.TextBoxControl();
            this.phoneTextBox = new HeroPecApp.Controls.TextBoxControl();
            this.loginTextBox = new HeroPecApp.Controls.TextBoxControl();
            this.nicknameTextBox = new HeroPecApp.Controls.TextBoxControl();
            this.emailTextBox = new HeroPecApp.Controls.TextBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.wrapPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshCaptchaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captchaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.emailLabel.Location = new System.Drawing.Point(122, 139);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(54, 20);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email*";
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationButton.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.registrationButton.Location = new System.Drawing.Point(259, 441);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(189, 55);
            this.registrationButton.TabIndex = 8;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.label5.Location = new System.Drawing.Point(317, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "* - обязательные поля";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.loginLabel.Location = new System.Drawing.Point(122, 197);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(61, 20);
            this.loginLabel.TabIndex = 24;
            this.loginLabel.Text = "Логин*";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.nameLabel.Location = new System.Drawing.Point(395, 139);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(40, 20);
            this.nameLabel.TabIndex = 22;
            this.nameLabel.Text = "Имя";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.phoneLabel.Location = new System.Drawing.Point(395, 196);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(79, 20);
            this.phoneLabel.TabIndex = 26;
            this.phoneLabel.Text = "Телефон";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(122, 340);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(200, 20);
            this.confirmPasswordLabel.TabIndex = 31;
            this.confirmPasswordLabel.Text = "Подтверждение пароля*";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.passwordLabel.Location = new System.Drawing.Point(122, 262);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 20);
            this.passwordLabel.TabIndex = 28;
            this.passwordLabel.Text = "Пароль*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(197, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 35);
            this.label3.TabIndex = 33;
            this.label3.Text = "РЕГИСТРАЦИЯ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.label4.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.label4.Location = new System.Drawing.Point(269, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 31);
            this.label4.TabIndex = 34;
            this.label4.Text = "в Heropec Cloud";
            // 
            // captchaLabel
            // 
            this.captchaLabel.AutoSize = true;
            this.captchaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.captchaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.captchaLabel.Location = new System.Drawing.Point(395, 262);
            this.captchaLabel.Name = "captchaLabel";
            this.captchaLabel.Size = new System.Drawing.Size(89, 20);
            this.captchaLabel.TabIndex = 37;
            this.captchaLabel.Text = "Вы робот?";
            // 
            // wrapPictureBox
            // 
            this.wrapPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wrapPictureBox.Image = global::HeroPecApp.Properties.Resources.wrap;
            this.wrapPictureBox.Location = new System.Drawing.Point(643, 4);
            this.wrapPictureBox.Name = "wrapPictureBox";
            this.wrapPictureBox.Size = new System.Drawing.Size(24, 24);
            this.wrapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wrapPictureBox.TabIndex = 40;
            this.wrapPictureBox.TabStop = false;
            this.wrapPictureBox.Click += new System.EventHandler(this.wrapPictureBox_Click);
            this.wrapPictureBox.MouseLeave += new System.EventHandler(this.wrapPictureBox_MouseLeave);
            this.wrapPictureBox.MouseHover += new System.EventHandler(this.wrapPictureBox_MouseHover);
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitPictureBox.Image = global::HeroPecApp.Properties.Resources.exit;
            this.exitPictureBox.Location = new System.Drawing.Point(673, 4);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(24, 24);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPictureBox.TabIndex = 38;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            this.exitPictureBox.MouseLeave += new System.EventHandler(this.exitPictureBox_MouseLeave);
            this.exitPictureBox.MouseHover += new System.EventHandler(this.exitPictureBox_MouseHover);
            // 
            // refreshCaptchaPictureBox
            // 
            this.refreshCaptchaPictureBox.Image = global::HeroPecApp.Properties.Resources.refresh;
            this.refreshCaptchaPictureBox.Location = new System.Drawing.Point(398, 341);
            this.refreshCaptchaPictureBox.Name = "refreshCaptchaPictureBox";
            this.refreshCaptchaPictureBox.Size = new System.Drawing.Size(32, 32);
            this.refreshCaptchaPictureBox.TabIndex = 35;
            this.refreshCaptchaPictureBox.TabStop = false;
            this.refreshCaptchaPictureBox.Click += new System.EventHandler(this.refreshCaptchaPictureBox_Click);
            // 
            // captchaPictureBox
            // 
            this.captchaPictureBox.Location = new System.Drawing.Point(398, 282);
            this.captchaPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.captchaPictureBox.Name = "captchaPictureBox";
            this.captchaPictureBox.Size = new System.Drawing.Size(211, 54);
            this.captchaPictureBox.TabIndex = 15;
            this.captchaPictureBox.TabStop = false;
            // 
            // errorEmailLabel
            // 
            this.errorEmailLabel.AutoSize = true;
            this.errorEmailLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.errorEmailLabel.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorEmailLabel.Location = new System.Drawing.Point(183, 141);
            this.errorEmailLabel.Name = "errorEmailLabel";
            this.errorEmailLabel.Size = new System.Drawing.Size(152, 17);
            this.errorEmailLabel.TabIndex = 41;
            this.errorEmailLabel.Text = "Введите корректный Email!";
            // 
            // errorLoginLabel
            // 
            this.errorLoginLabel.AutoSize = true;
            this.errorLoginLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.errorLoginLabel.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLoginLabel.Location = new System.Drawing.Point(187, 198);
            this.errorLoginLabel.Name = "errorLoginLabel";
            this.errorLoginLabel.Size = new System.Drawing.Size(155, 17);
            this.errorLoginLabel.TabIndex = 42;
            this.errorLoginLabel.Text = "Введите корректный логин!";
            // 
            // errorPasswordLabel
            // 
            this.errorPasswordLabel.AutoSize = true;
            this.errorPasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.errorPasswordLabel.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorPasswordLabel.Location = new System.Drawing.Point(198, 263);
            this.errorPasswordLabel.Name = "errorPasswordLabel";
            this.errorPasswordLabel.Size = new System.Drawing.Size(164, 17);
            this.errorPasswordLabel.TabIndex = 45;
            this.errorPasswordLabel.Text = "Введите корректный пароль!";
            // 
            // errorConfirmPasswordLabel
            // 
            this.errorConfirmPasswordLabel.AutoSize = true;
            this.errorConfirmPasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.errorConfirmPasswordLabel.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorConfirmPasswordLabel.Location = new System.Drawing.Point(210, 395);
            this.errorConfirmPasswordLabel.Name = "errorConfirmPasswordLabel";
            this.errorConfirmPasswordLabel.Size = new System.Drawing.Size(127, 17);
            this.errorConfirmPasswordLabel.TabIndex = 46;
            this.errorConfirmPasswordLabel.Text = "Пароли не совпадают";
            // 
            // dragPanel
            // 
            this.dragPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dragPanel.Location = new System.Drawing.Point(-3, -1);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(708, 29);
            this.dragPanel.TabIndex = 47;
            this.dragPanel.TabStop = false;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            this.dragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseMove);
            // 
            // loadPictureBox
            // 
            this.loadPictureBox.Image = global::HeroPecApp.Properties.Resources.logogif;
            this.loadPictureBox.Location = new System.Drawing.Point(12, 130);
            this.loadPictureBox.Name = "loadPictureBox";
            this.loadPictureBox.Size = new System.Drawing.Size(676, 282);
            this.loadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadPictureBox.TabIndex = 72;
            this.loadPictureBox.TabStop = false;
            this.loadPictureBox.Visible = false;
            // 
            // passwordDifficultyLabel
            // 
            this.passwordDifficultyLabel.AutoSize = true;
            this.passwordDifficultyLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.passwordDifficultyLabel.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordDifficultyLabel.Location = new System.Drawing.Point(125, 318);
            this.passwordDifficultyLabel.Name = "passwordDifficultyLabel";
            this.passwordDifficultyLabel.Size = new System.Drawing.Size(94, 17);
            this.passwordDifficultyLabel.TabIndex = 73;
            this.passwordDifficultyLabel.Text = "Введите пароль";
            // 
            // infoPictureBox
            // 
            this.infoPictureBox.Image = global::HeroPecApp.Properties.Resources.HeroQuestion;
            this.infoPictureBox.Location = new System.Drawing.Point(12, 478);
            this.infoPictureBox.Name = "infoPictureBox";
            this.infoPictureBox.Size = new System.Drawing.Size(40, 38);
            this.infoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoPictureBox.TabIndex = 74;
            this.infoPictureBox.TabStop = false;
            this.infoPictureBox.Click += new System.EventHandler(this.infoPictureBox_Click);
            // 
            // captchaTextBox
            // 
            this.captchaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.captchaTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.captchaTextBox.BorderSize = 2;
            this.captchaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.captchaTextBox.Location = new System.Drawing.Point(438, 341);
            this.captchaTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.captchaTextBox.Name = "captchaTextBox";
            this.captchaTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.captchaTextBox.Size = new System.Drawing.Size(172, 31);
            this.captchaTextBox.TabIndex = 36;
            this.captchaTextBox.Texts = "";
            this.captchaTextBox.UnderlinedStyle = false;
            this.captchaTextBox.UseChar = false;
            // 
            // confirmationPasswordTextBox
            // 
            this.confirmationPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.confirmationPasswordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.confirmationPasswordTextBox.BorderSize = 2;
            this.confirmationPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmationPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.confirmationPasswordTextBox.Location = new System.Drawing.Point(125, 361);
            this.confirmationPasswordTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.confirmationPasswordTextBox.Name = "confirmationPasswordTextBox";
            this.confirmationPasswordTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.confirmationPasswordTextBox.Size = new System.Drawing.Size(212, 31);
            this.confirmationPasswordTextBox.TabIndex = 32;
            this.confirmationPasswordTextBox.Texts = "";
            this.confirmationPasswordTextBox.UnderlinedStyle = true;
            this.confirmationPasswordTextBox.UseChar = false;
            this.confirmationPasswordTextBox.Leave += new System.EventHandler(this.confirmationPasswordTextBox_Leave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.passwordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.passwordTextBox.BorderSize = 2;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.passwordTextBox.Location = new System.Drawing.Point(125, 284);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.passwordTextBox.Size = new System.Drawing.Size(212, 31);
            this.passwordTextBox.TabIndex = 29;
            this.passwordTextBox.Texts = "";
            this.passwordTextBox.UnderlinedStyle = true;
            this.passwordTextBox.UseChar = false;
            this.passwordTextBox.Changed += new System.Action(this.passwordTextBox_Changed);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.phoneTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.phoneTextBox.BorderSize = 2;
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.phoneTextBox.Location = new System.Drawing.Point(398, 218);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.phoneTextBox.Size = new System.Drawing.Size(212, 31);
            this.phoneTextBox.TabIndex = 27;
            this.phoneTextBox.Texts = "";
            this.phoneTextBox.UnderlinedStyle = true;
            this.phoneTextBox.UseChar = false;
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.loginTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.loginTextBox.BorderSize = 2;
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.loginTextBox.Location = new System.Drawing.Point(125, 218);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.loginTextBox.Size = new System.Drawing.Size(212, 31);
            this.loginTextBox.TabIndex = 25;
            this.loginTextBox.Texts = "";
            this.loginTextBox.UnderlinedStyle = true;
            this.loginTextBox.UseChar = false;
            this.loginTextBox.Leave += new System.EventHandler(this.loginTextBox_Leave);
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.nicknameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.nicknameTextBox.BorderSize = 2;
            this.nicknameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nicknameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.nicknameTextBox.Location = new System.Drawing.Point(398, 161);
            this.nicknameTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.nicknameTextBox.Size = new System.Drawing.Size(212, 31);
            this.nicknameTextBox.TabIndex = 23;
            this.nicknameTextBox.Texts = "";
            this.nicknameTextBox.UnderlinedStyle = true;
            this.nicknameTextBox.UseChar = false;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.emailTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.emailTextBox.BorderSize = 2;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.emailTextBox.Location = new System.Drawing.Point(125, 161);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.emailTextBox.Size = new System.Drawing.Size(212, 31);
            this.emailTextBox.TabIndex = 20;
            this.emailTextBox.Texts = "";
            this.emailTextBox.UnderlinedStyle = true;
            this.emailTextBox.UseChar = false;
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // RegistrationForm
            // 
            this.AcceptButton = this.registrationButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(700, 524);
            this.Controls.Add(this.loadPictureBox);
            this.Controls.Add(this.infoPictureBox);
            this.Controls.Add(this.passwordDifficultyLabel);
            this.Controls.Add(this.errorConfirmPasswordLabel);
            this.Controls.Add(this.errorPasswordLabel);
            this.Controls.Add(this.errorLoginLabel);
            this.Controls.Add(this.errorEmailLabel);
            this.Controls.Add(this.wrapPictureBox);
            this.Controls.Add(this.exitPictureBox);
            this.Controls.Add(this.captchaLabel);
            this.Controls.Add(this.captchaTextBox);
            this.Controls.Add(this.refreshCaptchaPictureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.confirmationPasswordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.captchaPictureBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.dragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "RegistrationForm";
            this.Text = "HeroPec Регистрация";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wrapPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshCaptchaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captchaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox captchaPictureBox;
        private Controls.TextBoxControl emailTextBox;
        private Controls.TextBoxControl nicknameTextBox;
        private System.Windows.Forms.Label loginLabel;
        private Controls.TextBoxControl loginTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private Controls.TextBoxControl phoneTextBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private Controls.TextBoxControl confirmationPasswordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private Controls.TextBoxControl passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox refreshCaptchaPictureBox;
        private Controls.TextBoxControl captchaTextBox;
        private System.Windows.Forms.Label captchaLabel;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.PictureBox wrapPictureBox;
        private System.Windows.Forms.Label errorEmailLabel;
        private System.Windows.Forms.Label errorLoginLabel;
        private System.Windows.Forms.Label errorPasswordLabel;
        private System.Windows.Forms.Label errorConfirmPasswordLabel;
        private System.Windows.Forms.PictureBox dragPanel;
        private System.Windows.Forms.PictureBox loadPictureBox;
        private System.Windows.Forms.Label passwordDifficultyLabel;
        private System.Windows.Forms.PictureBox infoPictureBox;
    }
}