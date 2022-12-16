
namespace HeroPecApp.Controls
{
    partial class HeroToggleSwitch
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textLabel = new System.Windows.Forms.Label();
            this.checkPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.checkPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.textLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.textLabel.Location = new System.Drawing.Point(45, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(30, 16);
            this.textLabel.TabIndex = 66;
            this.textLabel.Text = "text";
            this.textLabel.Click += new System.EventHandler(this.HeroToggleSwitch_Click);
            // 
            // checkPictureBox
            // 
            this.checkPictureBox.Image = global::HeroPecApp.Properties.Resources.toggleswitchoff;
            this.checkPictureBox.Location = new System.Drawing.Point(0, 1);
            this.checkPictureBox.Name = "checkPictureBox";
            this.checkPictureBox.Size = new System.Drawing.Size(40, 15);
            this.checkPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.checkPictureBox.TabIndex = 65;
            this.checkPictureBox.TabStop = false;
            this.checkPictureBox.Click += new System.EventHandler(this.HeroToggleSwitch_Click);
            // 
            // HeroToggleSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkPictureBox);
            this.Controls.Add(this.textLabel);
            this.Name = "HeroToggleSwitch";
            this.Size = new System.Drawing.Size(199, 20);
            this.Load += new System.EventHandler(this.HeroToggleSwitch_Load);
            this.Click += new System.EventHandler(this.HeroToggleSwitch_Click);
            ((System.ComponentModel.ISupportInitialize)(this.checkPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox checkPictureBox;
        private System.Windows.Forms.Label textLabel;
    }
}
