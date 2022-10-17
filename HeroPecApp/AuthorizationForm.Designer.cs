
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailLoginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.registerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.restoreLinkLabel = new System.Windows.Forms.LinkLabel();
            this.stayLoggedCheckBox = new System.Windows.Forms.CheckBox();
            this.emailTextBox = new HeroPecApp.Controls.TextBoxControl();
            this.textBoxControl1 = new HeroPecApp.Controls.TextBoxControl();
            this.loginLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toggleSwitch1 = new HeroPecApp.ToggleSwitch();
            this.toggleSwitch2 = new HeroPecApp.ToggleSwitch();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // authorizationButton
            // 
            this.authorizationButton.Location = new System.Drawing.Point(288, 353);
            this.authorizationButton.Name = "authorizationButton";
            this.authorizationButton.Size = new System.Drawing.Size(139, 36);
            this.authorizationButton.TabIndex = 0;
            this.authorizationButton.Text = "Войти";
            this.authorizationButton.UseVisualStyleBackColor = true;
            this.authorizationButton.Click += new System.EventHandler(this.authorizationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин/Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // emailLoginTextBox
            // 
            this.emailLoginTextBox.Location = new System.Drawing.Point(18, 25);
            this.emailLoginTextBox.Name = "emailLoginTextBox";
            this.emailLoginTextBox.Size = new System.Drawing.Size(139, 20);
            this.emailLoginTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(18, 64);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(139, 20);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(18, 94);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(114, 17);
            this.showPasswordCheckBox.TabIndex = 5;
            this.showPasswordCheckBox.Text = "Показать пароль";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // registerLinkLabel
            // 
            this.registerLinkLabel.AutoSize = true;
            this.registerLinkLabel.Location = new System.Drawing.Point(15, 143);
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
            this.restoreLinkLabel.Location = new System.Drawing.Point(15, 130);
            this.restoreLinkLabel.Name = "restoreLinkLabel";
            this.restoreLinkLabel.Size = new System.Drawing.Size(117, 13);
            this.restoreLinkLabel.TabIndex = 7;
            this.restoreLinkLabel.TabStop = true;
            this.restoreLinkLabel.Text = "Восстановить пароль";
            this.restoreLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.restoreLinkLabel_LinkClicked);
            // 
            // stayLoggedCheckBox
            // 
            this.stayLoggedCheckBox.AutoSize = true;
            this.stayLoggedCheckBox.Location = new System.Drawing.Point(18, 110);
            this.stayLoggedCheckBox.Name = "stayLoggedCheckBox";
            this.stayLoggedCheckBox.Size = new System.Drawing.Size(111, 17);
            this.stayLoggedCheckBox.TabIndex = 8;
            this.stayLoggedCheckBox.Text = "Запомнить меня";
            this.stayLoggedCheckBox.UseVisualStyleBackColor = true;
            this.stayLoggedCheckBox.CheckedChanged += new System.EventHandler(this.stayLoggedCheckBox_CheckedChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.emailTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.emailTextBox.BorderSize = 3;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.emailTextBox.Location = new System.Drawing.Point(254, 197);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.emailTextBox.Size = new System.Drawing.Size(212, 31);
            this.emailTextBox.TabIndex = 21;
            this.emailTextBox.Texts = "";
            this.emailTextBox.UnderlinedStyle = false;
            // 
            // textBoxControl1
            // 
            this.textBoxControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.textBoxControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.textBoxControl1.BorderSize = 3;
            this.textBoxControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.textBoxControl1.Location = new System.Drawing.Point(254, 255);
            this.textBoxControl1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBoxControl1.Name = "textBoxControl1";
            this.textBoxControl1.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxControl1.Size = new System.Drawing.Size(212, 31);
            this.textBoxControl1.TabIndex = 22;
            this.textBoxControl1.Texts = "";
            this.textBoxControl1.UnderlinedStyle = false;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginLabel.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.loginLabel.Location = new System.Drawing.Point(335, 178);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(50, 18);
            this.loginLabel.TabIndex = 25;
            this.loginLabel.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(329, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Пароль";
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.toggleSwitch1.BackColorOFF = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.toggleSwitch1.BackColorON = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.toggleSwitch1.Checked = false;
            this.toggleSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleSwitch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.toggleSwitch1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.toggleSwitch1.Location = new System.Drawing.Point(277, 292);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Size = new System.Drawing.Size(167, 15);
            this.toggleSwitch1.TabIndex = 27;
            this.toggleSwitch1.Text = "Показать пароль";
            this.toggleSwitch1.TextOnChecked = "";
            // 
            // toggleSwitch2
            // 
            this.toggleSwitch2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.toggleSwitch2.BackColorOFF = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.toggleSwitch2.BackColorON = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.toggleSwitch2.Checked = false;
            this.toggleSwitch2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleSwitch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.toggleSwitch2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.toggleSwitch2.Location = new System.Drawing.Point(279, 313);
            this.toggleSwitch2.Name = "toggleSwitch2";
            this.toggleSwitch2.Size = new System.Drawing.Size(163, 15);
            this.toggleSwitch2.TabIndex = 28;
            this.toggleSwitch2.Text = "Запомнить меня";
            this.toggleSwitch2.TextOnChecked = "";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::HeroPecApp.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(254, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(212, 153);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 29;
            this.logoPictureBox.TabStop = false;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(684, 488);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.toggleSwitch2);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.textBoxControl1);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.stayLoggedCheckBox);
            this.Controls.Add(this.restoreLinkLabel);
            this.Controls.Add(this.registerLinkLabel);
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailLoginTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorizationButton);
            this.Name = "AuthorizationForm";
            this.Text = "AuthorizationForm";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authorizationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailLoginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private System.Windows.Forms.LinkLabel registerLinkLabel;
        private System.Windows.Forms.LinkLabel restoreLinkLabel;
        private System.Windows.Forms.CheckBox stayLoggedCheckBox;
        private Controls.TextBoxControl emailTextBox;
        private Controls.TextBoxControl textBoxControl1;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label label3;
        private ToggleSwitch toggleSwitch1;
        private ToggleSwitch toggleSwitch2;
        private System.Windows.Forms.PictureBox logoPictureBox;
    }
}