
namespace HeroPecApp
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.registerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.restoreLinkLabel = new System.Windows.Forms.LinkLabel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.authorizationButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.dragPanel = new System.Windows.Forms.PictureBox();
            this.wrapPictureBox = new System.Windows.Forms.PictureBox();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.configurationPictureBox = new System.Windows.Forms.PictureBox();
            this.offlineModeToggleSwitch = new HeroPecApp.Controls.HeroToggleSwitch();
            this.stayLoggedToggleSwitch = new HeroPecApp.Controls.HeroToggleSwitch();
            this.showPasswordToggleSwitch = new HeroPecApp.Controls.HeroToggleSwitch();
            this.passwordTextBox = new HeroPecApp.Controls.TextBoxControl();
            this.emailLoginTextBox = new HeroPecApp.Controls.TextBoxControl();
            this.infoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrapPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // registerLinkLabel
            // 
            this.registerLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.registerLinkLabel.AutoSize = true;
            this.registerLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.registerLinkLabel.Location = new System.Drawing.Point(276, 468);
            this.registerLinkLabel.Name = "registerLinkLabel";
            this.registerLinkLabel.Size = new System.Drawing.Size(72, 13);
            this.registerLinkLabel.TabIndex = 6;
            this.registerLinkLabel.TabStop = true;
            this.registerLinkLabel.Text = "Регистрация";
            this.registerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLinkLabel_LinkClicked);
            // 
            // restoreLinkLabel
            // 
            this.restoreLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreLinkLabel.AutoSize = true;
            this.restoreLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.restoreLinkLabel.Location = new System.Drawing.Point(276, 455);
            this.restoreLinkLabel.Name = "restoreLinkLabel";
            this.restoreLinkLabel.Size = new System.Drawing.Size(117, 13);
            this.restoreLinkLabel.TabIndex = 7;
            this.restoreLinkLabel.TabStop = true;
            this.restoreLinkLabel.Text = "Восстановить пароль";
            this.restoreLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.restoreLinkLabel_LinkClicked);
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.loginLabel.AutoSize = true;
            this.loginLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.loginLabel.Location = new System.Drawing.Point(326, 224);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(50, 18);
            this.loginLabel.TabIndex = 25;
            this.loginLabel.Text = "Логин";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(320, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Пароль";
            // 
            // authorizationButton
            // 
            this.authorizationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.authorizationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorizationButton.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorizationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.authorizationButton.Location = new System.Drawing.Point(279, 409);
            this.authorizationButton.Name = "authorizationButton";
            this.authorizationButton.Size = new System.Drawing.Size(139, 45);
            this.authorizationButton.TabIndex = 53;
            this.authorizationButton.Text = "Войти";
            this.authorizationButton.UseVisualStyleBackColor = false;
            this.authorizationButton.Click += new System.EventHandler(this.authorizationButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(245, 32);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(212, 179);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 29;
            this.logoPictureBox.TabStop = false;
            // 
            // dragPanel
            // 
            this.dragPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dragPanel.Location = new System.Drawing.Point(-8, -2);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(712, 29);
            this.dragPanel.TabIndex = 57;
            this.dragPanel.TabStop = false;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            this.dragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseMove);
            // 
            // wrapPictureBox
            // 
            this.wrapPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wrapPictureBox.Image = global::HeroPecApp.Properties.Resources.wrap;
            this.wrapPictureBox.Location = new System.Drawing.Point(642, 2);
            this.wrapPictureBox.Name = "wrapPictureBox";
            this.wrapPictureBox.Size = new System.Drawing.Size(24, 24);
            this.wrapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wrapPictureBox.TabIndex = 56;
            this.wrapPictureBox.TabStop = false;
            this.wrapPictureBox.Click += new System.EventHandler(this.wrapPictureBox_Click);
            this.wrapPictureBox.MouseLeave += new System.EventHandler(this.wrapPictureBox_MouseLeave);
            this.wrapPictureBox.MouseHover += new System.EventHandler(this.wrapPictureBox_MouseHover);
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitPictureBox.Image = global::HeroPecApp.Properties.Resources.exit;
            this.exitPictureBox.Location = new System.Drawing.Point(672, 2);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(24, 24);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPictureBox.TabIndex = 54;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            this.exitPictureBox.MouseLeave += new System.EventHandler(this.exitPictureBox_MouseLeave);
            this.exitPictureBox.MouseHover += new System.EventHandler(this.exitPictureBox_MouseHover);
            // 
            // configurationPictureBox
            // 
            this.configurationPictureBox.Image = global::HeroPecApp.Properties.Resources.conf;
            this.configurationPictureBox.Location = new System.Drawing.Point(642, 449);
            this.configurationPictureBox.Name = "configurationPictureBox";
            this.configurationPictureBox.Size = new System.Drawing.Size(54, 33);
            this.configurationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.configurationPictureBox.TabIndex = 58;
            this.configurationPictureBox.TabStop = false;
            this.configurationPictureBox.Click += new System.EventHandler(this.configurationPictureBox_Click);
            // 
            // offlineModeToggleSwitch
            // 
            this.offlineModeToggleSwitch.Checked = false;
            this.offlineModeToggleSwitch.Location = new System.Drawing.Point(268, 382);
            this.offlineModeToggleSwitch.Name = "offlineModeToggleSwitch";
            this.offlineModeToggleSwitch.Size = new System.Drawing.Size(189, 16);
            this.offlineModeToggleSwitch.TabIndex = 67;
            this.offlineModeToggleSwitch.Texts = "Автономный режим";
            this.offlineModeToggleSwitch.CheckedChanged += new System.Action(this.offlineModeToggleSwitch_CheckedChanged);
            // 
            // stayLoggedToggleSwitch
            // 
            this.stayLoggedToggleSwitch.Checked = false;
            this.stayLoggedToggleSwitch.Location = new System.Drawing.Point(268, 360);
            this.stayLoggedToggleSwitch.Name = "stayLoggedToggleSwitch";
            this.stayLoggedToggleSwitch.Size = new System.Drawing.Size(175, 16);
            this.stayLoggedToggleSwitch.TabIndex = 66;
            this.stayLoggedToggleSwitch.Texts = "Запомнить меня";
            this.stayLoggedToggleSwitch.CheckedChanged += new System.Action(this.stayLoggedToggleSwitch_CheckedChanged);
            // 
            // showPasswordToggleSwitch
            // 
            this.showPasswordToggleSwitch.Checked = false;
            this.showPasswordToggleSwitch.Location = new System.Drawing.Point(268, 338);
            this.showPasswordToggleSwitch.Name = "showPasswordToggleSwitch";
            this.showPasswordToggleSwitch.Size = new System.Drawing.Size(175, 16);
            this.showPasswordToggleSwitch.TabIndex = 65;
            this.showPasswordToggleSwitch.Texts = "Показать пароль";
            this.showPasswordToggleSwitch.CheckedChanged += new System.Action(this.showPasswordToggleSwitch_CheckedChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.passwordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.passwordTextBox.BorderSize = 3;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.passwordTextBox.Location = new System.Drawing.Point(245, 301);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.passwordTextBox.Size = new System.Drawing.Size(212, 31);
            this.passwordTextBox.TabIndex = 22;
            this.passwordTextBox.Texts = "";
            this.passwordTextBox.UnderlinedStyle = false;
            this.passwordTextBox.UseChar = true;
            // 
            // emailLoginTextBox
            // 
            this.emailLoginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.emailLoginTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.emailLoginTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.emailLoginTextBox.BorderSize = 3;
            this.emailLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLoginTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.emailLoginTextBox.Location = new System.Drawing.Point(245, 243);
            this.emailLoginTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.emailLoginTextBox.Name = "emailLoginTextBox";
            this.emailLoginTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.emailLoginTextBox.Size = new System.Drawing.Size(212, 31);
            this.emailLoginTextBox.TabIndex = 21;
            this.emailLoginTextBox.Texts = "";
            this.emailLoginTextBox.UnderlinedStyle = false;
            this.emailLoginTextBox.UseChar = false;
            // 
            // infoPictureBox
            // 
            this.infoPictureBox.Image = global::HeroPecApp.Properties.Resources.HeroQuestion;
            this.infoPictureBox.Location = new System.Drawing.Point(12, 444);
            this.infoPictureBox.Name = "infoPictureBox";
            this.infoPictureBox.Size = new System.Drawing.Size(40, 38);
            this.infoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoPictureBox.TabIndex = 71;
            this.infoPictureBox.TabStop = false;
            this.infoPictureBox.Click += new System.EventHandler(this.infoPictureBox_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(702, 488);
            this.Controls.Add(this.infoPictureBox);
            this.Controls.Add(this.offlineModeToggleSwitch);
            this.Controls.Add(this.stayLoggedToggleSwitch);
            this.Controls.Add(this.showPasswordToggleSwitch);
            this.Controls.Add(this.configurationPictureBox);
            this.Controls.Add(this.wrapPictureBox);
            this.Controls.Add(this.exitPictureBox);
            this.Controls.Add(this.authorizationButton);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailLoginTextBox);
            this.Controls.Add(this.restoreLinkLabel);
            this.Controls.Add(this.registerLinkLabel);
            this.Controls.Add(this.dragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HeroPec Авторизация";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrapPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel registerLinkLabel;
        private System.Windows.Forms.LinkLabel restoreLinkLabel;
        private Controls.TextBoxControl emailLoginTextBox;
        private Controls.TextBoxControl passwordTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button authorizationButton;
        private System.Windows.Forms.PictureBox dragPanel;
        private System.Windows.Forms.PictureBox wrapPictureBox;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.PictureBox configurationPictureBox;
        private Controls.HeroToggleSwitch showPasswordToggleSwitch;
        private Controls.HeroToggleSwitch stayLoggedToggleSwitch;
        private Controls.HeroToggleSwitch offlineModeToggleSwitch;
        private System.Windows.Forms.PictureBox infoPictureBox;
    }
}