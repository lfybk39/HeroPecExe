
namespace HeroPecApp
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.filesListView = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.addFileButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.loadPictureBox = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.loadPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // filesListView
            // 
            this.filesListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.filesListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filesListView.Dock = System.Windows.Forms.DockStyle.Right;
            this.filesListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.filesListView.HideSelection = false;
            this.filesListView.Location = new System.Drawing.Point(317, 0);
            this.filesListView.Name = "filesListView";
            this.filesListView.Size = new System.Drawing.Size(483, 450);
            this.filesListView.TabIndex = 0;
            this.filesListView.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.label4.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.label4.Location = new System.Drawing.Point(75, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 31);
            this.label4.TabIndex = 35;
            this.label4.Text = "Heropec Cloud";
            // 
            // addFileButton
            // 
            this.addFileButton.Location = new System.Drawing.Point(81, 96);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(104, 23);
            this.addFileButton.TabIndex = 36;
            this.addFileButton.Text = "Добавить файл";
            this.addFileButton.UseVisualStyleBackColor = true;
            this.addFileButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(81, 125);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(104, 23);
            this.deleteButton.TabIndex = 38;
            this.deleteButton.Text = "Удaлить файл";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // loadPictureBox
            // 
            this.loadPictureBox.Image = global::HeroPecApp.Properties.Resources.logo;
            this.loadPictureBox.Location = new System.Drawing.Point(428, 96);
            this.loadPictureBox.Name = "loadPictureBox";
            this.loadPictureBox.Size = new System.Drawing.Size(234, 259);
            this.loadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadPictureBox.TabIndex = 39;
            this.loadPictureBox.TabStop = false;
            this.loadPictureBox.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 40;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.loadPictureBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addFileButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filesListView);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView filesListView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addFileButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.PictureBox loadPictureBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}

