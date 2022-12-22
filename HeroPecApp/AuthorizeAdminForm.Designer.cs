
namespace HeroPecApp
{
    partial class AuthorizeAdminForm
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
            this.wrapPictureBox = new System.Windows.Forms.PictureBox();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.dragPanel = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordTextBox = new HeroPecApp.Controls.TextBoxControl();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wrapPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // wrapPictureBox
            // 
            this.wrapPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wrapPictureBox.Image = global::HeroPecApp.Properties.Resources.wrap;
            this.wrapPictureBox.Location = new System.Drawing.Point(428, 4);
            this.wrapPictureBox.Name = "wrapPictureBox";
            this.wrapPictureBox.Size = new System.Drawing.Size(24, 24);
            this.wrapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wrapPictureBox.TabIndex = 59;
            this.wrapPictureBox.TabStop = false;
            this.wrapPictureBox.Click += new System.EventHandler(this.wrapPictureBox_Click);
            this.wrapPictureBox.MouseLeave += new System.EventHandler(this.wrapPictureBox_MouseLeave);
            this.wrapPictureBox.MouseHover += new System.EventHandler(this.wrapPictureBox_MouseHover);
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitPictureBox.Image = global::HeroPecApp.Properties.Resources.exit;
            this.exitPictureBox.Location = new System.Drawing.Point(458, 4);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(24, 24);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPictureBox.TabIndex = 58;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            this.exitPictureBox.MouseLeave += new System.EventHandler(this.exitPictureBox_MouseLeave);
            this.exitPictureBox.MouseHover += new System.EventHandler(this.exitPictureBox_MouseHover);
            // 
            // dragPanel
            // 
            this.dragPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dragPanel.Location = new System.Drawing.Point(-5, -5);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(496, 34);
            this.dragPanel.TabIndex = 60;
            this.dragPanel.TabStop = false;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            this.dragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.label5.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.label5.Location = new System.Drawing.Point(177, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 31);
            this.label5.TabIndex = 62;
            this.label5.Text = "НАСТРОЙКИ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.label4.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 20.2F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.label4.Location = new System.Drawing.Point(161, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 31);
            this.label4.TabIndex = 61;
            this.label4.Text = "Heropec Cloud";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.passwordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.passwordTextBox.BorderSize = 3;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.passwordTextBox.Location = new System.Drawing.Point(95, 121);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.passwordTextBox.Size = new System.Drawing.Size(277, 31);
            this.passwordTextBox.TabIndex = 63;
            this.passwordTextBox.Texts = "";
            this.passwordTextBox.UnderlinedStyle = false;
            this.passwordTextBox.UseChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.passwordLabel.Location = new System.Drawing.Point(120, 103);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(228, 15);
            this.passwordLabel.TabIndex = 64;
            this.passwordLabel.Text = "Пароль администратора приложения";
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.enterButton.Location = new System.Drawing.Point(171, 158);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(120, 31);
            this.enterButton.TabIndex = 65;
            this.enterButton.Text = "Войти";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // AuthorizeAdminForm
            // 
            this.AcceptButton = this.enterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(488, 193);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wrapPictureBox);
            this.Controls.Add(this.exitPictureBox);
            this.Controls.Add(this.dragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorizeAdminForm";
            this.Text = "HeroPec настройки";
            ((System.ComponentModel.ISupportInitialize)(this.wrapPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox wrapPictureBox;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.PictureBox dragPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Controls.TextBoxControl passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button enterButton;
    }
}