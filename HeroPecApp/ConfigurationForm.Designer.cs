
namespace HeroPecApp
{
    partial class ConfigurationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            this.usersLinkLabel = new System.Windows.Forms.LinkLabel();
            this.folderTextBox = new HeroPecApp.Controls.TextBoxControl();
            this.passwordTextBox = new HeroPecApp.Controls.TextBoxControl();
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderPictureBox = new System.Windows.Forms.PictureBox();
            this.dragPanel = new System.Windows.Forms.PictureBox();
            this.wrapPictureBox = new System.Windows.Forms.PictureBox();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.showPasswordCheckBox = new HeroPecApp.ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.databaseTextBox = new HeroPecApp.Controls.TextBoxControl();
            this.label3 = new System.Windows.Forms.Label();
            this.userIDTextBox = new HeroPecApp.Controls.TextBoxControl();
            this.label6 = new System.Windows.Forms.Label();
            this.userPasswordTextBox = new HeroPecApp.Controls.TextBoxControl();
            this.label7 = new System.Windows.Forms.Label();
            this.serverIPTextBox = new HeroPecApp.Controls.TextBoxControl();
            this.label8 = new System.Windows.Forms.Label();
            this.serverPortTextBox = new HeroPecApp.Controls.TextBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.folderPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrapPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usersLinkLabel
            // 
            this.usersLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.usersLinkLabel.AutoSize = true;
            this.usersLinkLabel.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.usersLinkLabel.Location = new System.Drawing.Point(229, 462);
            this.usersLinkLabel.Name = "usersLinkLabel";
            this.usersLinkLabel.Size = new System.Drawing.Size(142, 15);
            this.usersLinkLabel.TabIndex = 8;
            this.usersLinkLabel.TabStop = true;
            this.usersLinkLabel.Text = "Управление пользователями";
            this.usersLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.usersLinkLabel_LinkClicked);
            // 
            // folderTextBox
            // 
            this.folderTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.folderTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.folderTextBox.BorderSize = 3;
            this.folderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.folderTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.folderTextBox.Location = new System.Drawing.Point(13, 138);
            this.folderTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.folderTextBox.Size = new System.Drawing.Size(212, 31);
            this.folderTextBox.TabIndex = 28;
            this.folderTextBox.Texts = "";
            this.folderTextBox.UnderlinedStyle = false;
            this.folderTextBox.UseChar = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.passwordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.passwordTextBox.BorderSize = 3;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.passwordTextBox.Location = new System.Drawing.Point(13, 197);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.passwordTextBox.Size = new System.Drawing.Size(212, 31);
            this.passwordTextBox.TabIndex = 29;
            this.passwordTextBox.Texts = "";
            this.passwordTextBox.UnderlinedStyle = false;
            this.passwordTextBox.UseChar = true;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.saveButton.Location = new System.Drawing.Point(223, 412);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(148, 47);
            this.saveButton.TabIndex = 45;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.label4.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 20.2F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.label4.Location = new System.Drawing.Point(225, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 31);
            this.label4.TabIndex = 46;
            this.label4.Text = "Heropec Cloud";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.label5.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.label5.Location = new System.Drawing.Point(241, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 31);
            this.label5.TabIndex = 47;
            this.label5.Text = "НАСТРОЙКИ";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.emailLabel.Location = new System.Drawing.Point(12, 120);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(195, 15);
            this.emailLabel.TabIndex = 48;
            this.emailLabel.Text = "Папка для локального хранения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(10, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 15);
            this.label2.TabIndex = 50;
            this.label2.Text = "Пароль администратора приложения";
            // 
            // folderPictureBox
            // 
            this.folderPictureBox.Image = global::HeroPecApp.Properties.Resources.folderico;
            this.folderPictureBox.Location = new System.Drawing.Point(223, 138);
            this.folderPictureBox.Name = "folderPictureBox";
            this.folderPictureBox.Size = new System.Drawing.Size(47, 31);
            this.folderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.folderPictureBox.TabIndex = 51;
            this.folderPictureBox.TabStop = false;
            this.folderPictureBox.Click += new System.EventHandler(this.folderPictureBox_Click);
            // 
            // dragPanel
            // 
            this.dragPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dragPanel.Location = new System.Drawing.Point(-89, -1);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(694, 29);
            this.dragPanel.TabIndex = 55;
            this.dragPanel.TabStop = false;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            this.dragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseMove);
            // 
            // wrapPictureBox
            // 
            this.wrapPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wrapPictureBox.Image = global::HeroPecApp.Properties.Resources.wrap;
            this.wrapPictureBox.Location = new System.Drawing.Point(547, 0);
            this.wrapPictureBox.Name = "wrapPictureBox";
            this.wrapPictureBox.Size = new System.Drawing.Size(24, 24);
            this.wrapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wrapPictureBox.TabIndex = 54;
            this.wrapPictureBox.TabStop = false;
            this.wrapPictureBox.Click += new System.EventHandler(this.wrapPictureBox_Click);
            this.wrapPictureBox.MouseLeave += new System.EventHandler(this.wrapPictureBox_MouseLeave);
            this.wrapPictureBox.MouseHover += new System.EventHandler(this.wrapPictureBox_MouseHover);
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitPictureBox.Image = global::HeroPecApp.Properties.Resources.exit;
            this.exitPictureBox.Location = new System.Drawing.Point(577, 0);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(24, 24);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPictureBox.TabIndex = 52;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            this.exitPictureBox.MouseLeave += new System.EventHandler(this.exitPictureBox_MouseLeave);
            this.exitPictureBox.MouseHover += new System.EventHandler(this.exitPictureBox_MouseHover);
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.showPasswordCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.showPasswordCheckBox.BackColorOFF = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.showPasswordCheckBox.BackColorON = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.showPasswordCheckBox.Checked = false;
            this.showPasswordCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPasswordCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.showPasswordCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.showPasswordCheckBox.Location = new System.Drawing.Point(40, 234);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(167, 15);
            this.showPasswordCheckBox.TabIndex = 56;
            this.showPasswordCheckBox.Text = "Показать пароль";
            this.showPasswordCheckBox.TextOnChecked = "";
            this.showPasswordCheckBox.CheckedChanged += new HeroPecApp.ToggleSwitch.OnCheckedChangedHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(319, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 58;
            this.label1.Text = "Имя БД";
            // 
            // databaseTextBox
            // 
            this.databaseTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.databaseTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.databaseTextBox.BorderSize = 3;
            this.databaseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.databaseTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.databaseTextBox.Location = new System.Drawing.Point(320, 138);
            this.databaseTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.databaseTextBox.Name = "databaseTextBox";
            this.databaseTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.databaseTextBox.Size = new System.Drawing.Size(212, 31);
            this.databaseTextBox.TabIndex = 57;
            this.databaseTextBox.Texts = "";
            this.databaseTextBox.UnderlinedStyle = false;
            this.databaseTextBox.UseChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(319, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 15);
            this.label3.TabIndex = 60;
            this.label3.Text = "Логин пользователя БД";
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.userIDTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.userIDTextBox.BorderSize = 3;
            this.userIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userIDTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.userIDTextBox.Location = new System.Drawing.Point(320, 197);
            this.userIDTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.userIDTextBox.Size = new System.Drawing.Size(212, 31);
            this.userIDTextBox.TabIndex = 59;
            this.userIDTextBox.Texts = "";
            this.userIDTextBox.UnderlinedStyle = false;
            this.userIDTextBox.UseChar = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.label6.Location = new System.Drawing.Point(319, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 15);
            this.label6.TabIndex = 62;
            this.label6.Text = "Пароль пользователя БД";
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.userPasswordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.userPasswordTextBox.BorderSize = 3;
            this.userPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.userPasswordTextBox.Location = new System.Drawing.Point(320, 251);
            this.userPasswordTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.userPasswordTextBox.Size = new System.Drawing.Size(212, 31);
            this.userPasswordTextBox.TabIndex = 61;
            this.userPasswordTextBox.Texts = "";
            this.userPasswordTextBox.UnderlinedStyle = false;
            this.userPasswordTextBox.UseChar = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.label7.Location = new System.Drawing.Point(319, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 64;
            this.label7.Text = "IP-адрес сервера";
            // 
            // serverIPTextBox
            // 
            this.serverIPTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.serverIPTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.serverIPTextBox.BorderSize = 3;
            this.serverIPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serverIPTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.serverIPTextBox.Location = new System.Drawing.Point(320, 306);
            this.serverIPTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.serverIPTextBox.Name = "serverIPTextBox";
            this.serverIPTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.serverIPTextBox.Size = new System.Drawing.Size(212, 31);
            this.serverIPTextBox.TabIndex = 63;
            this.serverIPTextBox.Texts = "";
            this.serverIPTextBox.UnderlinedStyle = false;
            this.serverIPTextBox.UseChar = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.label8.Location = new System.Drawing.Point(319, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 15);
            this.label8.TabIndex = 66;
            this.label8.Text = "Порт сервера";
            // 
            // serverPortTextBox
            // 
            this.serverPortTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.serverPortTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.serverPortTextBox.BorderSize = 3;
            this.serverPortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serverPortTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.serverPortTextBox.Location = new System.Drawing.Point(320, 357);
            this.serverPortTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.serverPortTextBox.Name = "serverPortTextBox";
            this.serverPortTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.serverPortTextBox.Size = new System.Drawing.Size(212, 31);
            this.serverPortTextBox.TabIndex = 65;
            this.serverPortTextBox.Texts = "";
            this.serverPortTextBox.UnderlinedStyle = false;
            this.serverPortTextBox.UseChar = false;
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(604, 486);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.serverPortTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.serverIPTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.userPasswordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.databaseTextBox);
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.wrapPictureBox);
            this.Controls.Add(this.exitPictureBox);
            this.Controls.Add(this.folderPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.folderTextBox);
            this.Controls.Add(this.usersLinkLabel);
            this.Controls.Add(this.dragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigurationForm";
            this.Text = "ConfigurationForm";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.folderPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrapPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel usersLinkLabel;
        private Controls.TextBoxControl folderTextBox;
        private Controls.TextBoxControl passwordTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox folderPictureBox;
        private System.Windows.Forms.PictureBox dragPanel;
        private System.Windows.Forms.PictureBox wrapPictureBox;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private ToggleSwitch showPasswordCheckBox;
        private System.Windows.Forms.Label label1;
        private Controls.TextBoxControl databaseTextBox;
        private System.Windows.Forms.Label label3;
        private Controls.TextBoxControl userIDTextBox;
        private System.Windows.Forms.Label label6;
        private Controls.TextBoxControl userPasswordTextBox;
        private System.Windows.Forms.Label label7;
        private Controls.TextBoxControl serverIPTextBox;
        private System.Windows.Forms.Label label8;
        private Controls.TextBoxControl serverPortTextBox;
    }
}