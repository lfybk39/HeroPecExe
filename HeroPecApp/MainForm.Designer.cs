
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
            this.localFilesListView = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.addFileButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cloudFilesListView = new System.Windows.Forms.ListView();
            this.loadPictureBox = new System.Windows.Forms.PictureBox();
            this.cloudLocalCheckBox = new HeroPecApp.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.loadPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // localFilesListView
            // 
            this.localFilesListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.localFilesListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.localFilesListView.Dock = System.Windows.Forms.DockStyle.Right;
            this.localFilesListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.localFilesListView.HideSelection = false;
            this.localFilesListView.Location = new System.Drawing.Point(272, 0);
            this.localFilesListView.Name = "localFilesListView";
            this.localFilesListView.Size = new System.Drawing.Size(451, 529);
            this.localFilesListView.TabIndex = 0;
            this.localFilesListView.UseCompatibleStateImageBehavior = false;
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
            this.addFileButton.Location = new System.Drawing.Point(42, 68);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(104, 23);
            this.addFileButton.TabIndex = 36;
            this.addFileButton.Text = "Добавить файл";
            this.addFileButton.UseVisualStyleBackColor = true;
            this.addFileButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(42, 110);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(104, 23);
            this.deleteButton.TabIndex = 38;
            this.deleteButton.Text = "Удaлить файл";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 40;
            // 
            // cloudFilesListView
            // 
            this.cloudFilesListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cloudFilesListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.cloudFilesListView.Enabled = false;
            this.cloudFilesListView.HideSelection = false;
            this.cloudFilesListView.Location = new System.Drawing.Point(272, 0);
            this.cloudFilesListView.Name = "cloudFilesListView";
            this.cloudFilesListView.Size = new System.Drawing.Size(451, 529);
            this.cloudFilesListView.TabIndex = 41;
            this.cloudFilesListView.UseCompatibleStateImageBehavior = false;
            this.cloudFilesListView.Visible = false;
            // 
            // loadPictureBox
            // 
            this.loadPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.loadPictureBox.Image = global::HeroPecApp.Properties.Resources.logogif;
            this.loadPictureBox.Location = new System.Drawing.Point(332, 96);
            this.loadPictureBox.Name = "loadPictureBox";
            this.loadPictureBox.Size = new System.Drawing.Size(348, 339);
            this.loadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadPictureBox.TabIndex = 42;
            this.loadPictureBox.TabStop = false;
            // 
            // cloudLocalCheckBox
            // 
            this.cloudLocalCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cloudLocalCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.cloudLocalCheckBox.BackColorOFF = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.cloudLocalCheckBox.BackColorON = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.cloudLocalCheckBox.Checked = false;
            this.cloudLocalCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cloudLocalCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.cloudLocalCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            this.cloudLocalCheckBox.Location = new System.Drawing.Point(42, 153);
            this.cloudLocalCheckBox.Name = "cloudLocalCheckBox";
            this.cloudLocalCheckBox.Size = new System.Drawing.Size(192, 15);
            this.cloudLocalCheckBox.TabIndex = 43;
            this.cloudLocalCheckBox.Text = "Локальное хранение";
            this.cloudLocalCheckBox.TextOnChecked = "";
            this.cloudLocalCheckBox.CheckedChanged += new HeroPecApp.ToggleSwitch.OnCheckedChangedHandler(this.cloudLocalCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(723, 529);
            this.Controls.Add(this.cloudLocalCheckBox);
            this.Controls.Add(this.loadPictureBox);
            this.Controls.Add(this.cloudFilesListView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addFileButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.localFilesListView);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView localFilesListView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addFileButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView cloudFilesListView;
        private System.Windows.Forms.PictureBox loadPictureBox;
        private ToggleSwitch cloudLocalCheckBox;
    }
}

