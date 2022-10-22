
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
            this.authorizationButton = new System.Windows.Forms.Button();
            this.registerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.restoreLinkLabel = new System.Windows.Forms.LinkLabel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.dragPanel = new System.Windows.Forms.PictureBox();
            this.wrapPictureBox = new System.Windows.Forms.PictureBox();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.stayLoggedCheckBox = new HeroPecApp.ToggleSwitch();
            this.showPasswordCheckBox = new HeroPecApp.ToggleSwitch();
            this.passwordTextBox = new HeroPecApp.Controls.TextBoxControl();
            this.emailLoginTextBox = new HeroPecApp.Controls.TextBoxControl();
            this.maximizePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrapPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // authorizationButton
            // 
            this.authorizationButton.Location = new System.Drawing.Point(288, 399);
            this.authorizationButton.Name = "authorizationButton";
            this.authorizationButton.Size = new System.Drawing.Size(139, 36);
            this.authorizationButton.TabIndex = 0;
            this.authorizationButton.Text = "Войти";
            this.authorizationButton.UseVisualStyleBackColor = true;
            this.authorizationButton.Click += new System.EventHandler(this.authorizationButton_Click);
            // 
            // registerLinkLabel
            // 
            this.registerLinkLabel.AutoSize = true;
            this.registerLinkLabel.Location = new System.Drawing.Point(285, 451);
            this.registerLinkLabel.Name = "registerLinkLabel";
            this.registerLinkLabel.Size = new System.Drawing.Size(72, 13);
            this.registerLinkLabel.TabIndex = 6;
            this.registerLinkLabel.TabStop = true;
            this.registerLinkLabel.Text = "Регистрация";
            this.registerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLinkLabel_LinkClicked);
            // 
            // restoreLinkLabel
            // 
            this.restoreLinkLabel.AutoSize = true;
            this.restoreLinkLabel.Location = new System.Drawing.Point(285, 438);
            this.restoreLinkLabel.Name = "restoreLinkLabel";
            this.restoreLinkLabel.Size = new System.Drawing.Size(117, 13);
            this.restoreLinkLabel.TabIndex = 7;
            this.restoreLinkLabel.TabStop = true;
            this.restoreLinkLabel.Text = "Восстановить пароль";
            this.restoreLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.restoreLinkLabel_LinkClicked);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.loginLabel.Location = new System.Drawing.Point(335, 224);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(50, 18);
            this.loginLabel.TabIndex = 25;
            this.loginLabel.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(329, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Пароль";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::HeroPecApp.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(254, 58);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(212, 153);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 29;
            this.logoPictureBox.TabStop = false;
            // 
            // dragPanel
            // 
            this.dragPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dragPanel.Location = new System.Drawing.Point(-4, -3);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(604, 29);
            this.dragPanel.TabIndex = 51;
            this.dragPanel.TabStop = false;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            this.dragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseMove);
            // 
            // wrapPictureBox
            // 
            this.wrapPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wrapPictureBox.Image = global::HeroPecApp.Properties.Resources.wrap;
            this.wrapPictureBox.Location = new System.Drawing.Point(606, 2);
            this.wrapPictureBox.Name = "wrapPictureBox";
            this.wrapPictureBox.Size = new System.Drawing.Size(24, 24);
            this.wrapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wrapPictureBox.TabIndex = 50;
            this.wrapPictureBox.TabStop = false;
            this.wrapPictureBox.Click += new System.EventHandler(this.wrapPictureBox_Click);
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitPictureBox.Image = global::HeroPecApp.Properties.Resources.exit;
            this.exitPictureBox.Location = new System.Drawing.Point(666, 2);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(24, 24);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPictureBox.TabIndex = 48;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // stayLoggedCheckBox
            // 
            this.stayLoggedCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.stayLoggedCheckBox.BackColorOFF = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.stayLoggedCheckBox.BackColorON = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.stayLoggedCheckBox.Checked = false;
            this.stayLoggedCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stayLoggedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.stayLoggedCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.stayLoggedCheckBox.Location = new System.Drawing.Point(279, 359);
            this.stayLoggedCheckBox.Name = "stayLoggedCheckBox";
            this.stayLoggedCheckBox.Size = new System.Drawing.Size(163, 15);
            this.stayLoggedCheckBox.TabIndex = 28;
            this.stayLoggedCheckBox.Text = "Запомнить меня";
            this.stayLoggedCheckBox.TextOnChecked = "";
            this.stayLoggedCheckBox.CheckedChanged += new HeroPecApp.ToggleSwitch.OnCheckedChangedHandler(this.stayLoggedCheckBox_CheckedChanged);
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.showPasswordCheckBox.BackColorOFF = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.showPasswordCheckBox.BackColorON = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.showPasswordCheckBox.Checked = false;
            this.showPasswordCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPasswordCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.showPasswordCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.showPasswordCheckBox.Location = new System.Drawing.Point(277, 338);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(167, 15);
            this.showPasswordCheckBox.TabIndex = 27;
            this.showPasswordCheckBox.Text = "Показать пароль";
            this.showPasswordCheckBox.TextOnChecked = "";
            this.showPasswordCheckBox.CheckedChanged += new HeroPecApp.ToggleSwitch.OnCheckedChangedHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.passwordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.passwordTextBox.BorderSize = 3;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.passwordTextBox.Location = new System.Drawing.Point(254, 301);
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
            this.emailLoginTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.emailLoginTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.emailLoginTextBox.BorderSize = 3;
            this.emailLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLoginTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.emailLoginTextBox.Location = new System.Drawing.Point(254, 243);
            this.emailLoginTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.emailLoginTextBox.Name = "emailLoginTextBox";
            this.emailLoginTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.emailLoginTextBox.Size = new System.Drawing.Size(212, 31);
            this.emailLoginTextBox.TabIndex = 21;
            this.emailLoginTextBox.Texts = "";
            this.emailLoginTextBox.UnderlinedStyle = false;
            this.emailLoginTextBox.UseChar = false;
            // 
            // maximizePictureBox
            // 
            this.maximizePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizePictureBox.Image = global::HeroPecApp.Properties.Resources.maximize;
            this.maximizePictureBox.Location = new System.Drawing.Point(636, 2);
            this.maximizePictureBox.Name = "maximizePictureBox";
            this.maximizePictureBox.Size = new System.Drawing.Size(24, 24);
            this.maximizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizePictureBox.TabIndex = 49;
            this.maximizePictureBox.TabStop = false;
            this.maximizePictureBox.Click += new System.EventHandler(this.maximizePictureBox_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(702, 488);
            this.Controls.Add(this.dragPanel);
            this.Controls.Add(this.wrapPictureBox);
            this.Controls.Add(this.maximizePictureBox);
            this.Controls.Add(this.exitPictureBox);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.stayLoggedCheckBox);
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailLoginTextBox);
            this.Controls.Add(this.restoreLinkLabel);
            this.Controls.Add(this.registerLinkLabel);
            this.Controls.Add(this.authorizationButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorizationForm";
            this.Text = "AuthorizationForm";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrapPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authorizationButton;
        private System.Windows.Forms.LinkLabel registerLinkLabel;
        private System.Windows.Forms.LinkLabel restoreLinkLabel;
        private Controls.TextBoxControl emailLoginTextBox;
        private Controls.TextBoxControl passwordTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label label3;
        private ToggleSwitch showPasswordCheckBox;
        private ToggleSwitch stayLoggedCheckBox;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.PictureBox dragPanel;
        private System.Windows.Forms.PictureBox wrapPictureBox;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.PictureBox maximizePictureBox;
    }
}