
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
            this.folderButton = new System.Windows.Forms.Button();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usersLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // folderButton
            // 
            this.folderButton.Location = new System.Drawing.Point(321, 56);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(97, 20);
            this.folderButton.TabIndex = 0;
            this.folderButton.Text = "Выбрать";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // folderTextBox
            // 
            this.folderTextBox.Location = new System.Drawing.Point(12, 56);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(303, 20);
            this.folderTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Папка для локального хранения";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 175);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(138, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Сохранить настройки";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Логин администратора приложения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль администратора приложения";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(18, 95);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(137, 20);
            this.loginTextBox.TabIndex = 6;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(18, 134);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(137, 20);
            this.passwordTextBox.TabIndex = 7;
            // 
            // usersLinkLabel
            // 
            this.usersLinkLabel.AutoSize = true;
            this.usersLinkLabel.Location = new System.Drawing.Point(158, 180);
            this.usersLinkLabel.Name = "usersLinkLabel";
            this.usersLinkLabel.Size = new System.Drawing.Size(157, 13);
            this.usersLinkLabel.TabIndex = 8;
            this.usersLinkLabel.TabStop = true;
            this.usersLinkLabel.Text = "Управление пользователями";
            this.usersLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.usersLinkLabel_LinkClicked);
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 292);
            this.Controls.Add(this.usersLinkLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folderTextBox);
            this.Controls.Add(this.folderButton);
            this.Name = "ConfigurationForm";
            this.Text = "ConfigurationForm";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.TextBox folderTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.LinkLabel usersLinkLabel;
    }
}