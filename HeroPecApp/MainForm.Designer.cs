
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
            this.dragPanel = new System.Windows.Forms.PictureBox();
            this.wrapPictureBox = new System.Windows.Forms.PictureBox();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.loadPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.extractFileButton = new System.Windows.Forms.Button();
            this.cloudLocalCheckBox = new HeroPecApp.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.dragPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrapPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // filesListView
            // 
            this.filesListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.filesListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filesListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.filesListView.HideSelection = false;
            this.filesListView.Location = new System.Drawing.Point(272, 35);
            this.filesListView.Name = "filesListView";
            this.filesListView.Size = new System.Drawing.Size(451, 494);
            this.filesListView.TabIndex = 0;
            this.filesListView.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.label4.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 20.9F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.label4.Location = new System.Drawing.Point(52, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 32);
            this.label4.TabIndex = 35;
            this.label4.Text = "Heropec Cloud";
            // 
            // addFileButton
            // 
            this.addFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.addFileButton.FlatAppearance.BorderSize = 0;
            this.addFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFileButton.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.addFileButton.Location = new System.Drawing.Point(52, 124);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(148, 47);
            this.addFileButton.TabIndex = 44;
            this.addFileButton.Text = "Добавить файл";
            this.addFileButton.UseVisualStyleBackColor = false;
            this.addFileButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.deleteButton.Location = new System.Drawing.Point(52, 177);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(148, 47);
            this.deleteButton.TabIndex = 45;
            this.deleteButton.Text = "Удалить файл";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // dragPanel
            // 
            this.dragPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dragPanel.Location = new System.Drawing.Point(-2, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(725, 29);
            this.dragPanel.TabIndex = 59;
            this.dragPanel.TabStop = false;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            this.dragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseMove);
            // 
            // wrapPictureBox
            // 
            this.wrapPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wrapPictureBox.Image = global::HeroPecApp.Properties.Resources.wrap;
            this.wrapPictureBox.Location = new System.Drawing.Point(669, 5);
            this.wrapPictureBox.Name = "wrapPictureBox";
            this.wrapPictureBox.Size = new System.Drawing.Size(24, 24);
            this.wrapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wrapPictureBox.TabIndex = 58;
            this.wrapPictureBox.TabStop = false;
            this.wrapPictureBox.Click += new System.EventHandler(this.wrapPictureBox_Click);
            this.wrapPictureBox.MouseLeave += new System.EventHandler(this.wrapPictureBox_MouseLeave);
            this.wrapPictureBox.MouseHover += new System.EventHandler(this.wrapPictureBox_MouseHover);
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitPictureBox.Image = global::HeroPecApp.Properties.Resources.exit;
            this.exitPictureBox.Location = new System.Drawing.Point(699, 5);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(24, 24);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPictureBox.TabIndex = 56;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            this.exitPictureBox.MouseLeave += new System.EventHandler(this.exitPictureBox_MouseLeave);
            this.exitPictureBox.MouseHover += new System.EventHandler(this.exitPictureBox_MouseHover);
            // 
            // loadPictureBox
            // 
            this.loadPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.loadPictureBox.Image = global::HeroPecApp.Properties.Resources.logogif;
            this.loadPictureBox.Location = new System.Drawing.Point(272, 35);
            this.loadPictureBox.Name = "loadPictureBox";
            this.loadPictureBox.Size = new System.Drawing.Size(451, 494);
            this.loadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadPictureBox.TabIndex = 42;
            this.loadPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HeroPecApp.Properties.Resources._198198214;
            this.pictureBox1.Location = new System.Drawing.Point(-12, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // extractFileButton
            // 
            this.extractFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.extractFileButton.FlatAppearance.BorderSize = 0;
            this.extractFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extractFileButton.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.extractFileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.extractFileButton.Location = new System.Drawing.Point(52, 230);
            this.extractFileButton.Name = "extractFileButton";
            this.extractFileButton.Size = new System.Drawing.Size(148, 47);
            this.extractFileButton.TabIndex = 61;
            this.extractFileButton.Text = "Извлечь файл";
            this.extractFileButton.UseVisualStyleBackColor = false;
            this.extractFileButton.Click += new System.EventHandler(this.extractFileButton_Click);
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
            this.cloudLocalCheckBox.Location = new System.Drawing.Point(33, 400);
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
            this.Controls.Add(this.extractFileButton);
            this.Controls.Add(this.exitPictureBox);
            this.Controls.Add(this.wrapPictureBox);
            this.Controls.Add(this.dragPanel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addFileButton);
            this.Controls.Add(this.cloudLocalCheckBox);
            this.Controls.Add(this.loadPictureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filesListView);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HeroPec Cloud";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dragPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrapPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView filesListView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox loadPictureBox;
        private ToggleSwitch cloudLocalCheckBox;
        private System.Windows.Forms.Button addFileButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.PictureBox dragPanel;
        private System.Windows.Forms.PictureBox wrapPictureBox;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button extractFileButton;
    }
}

