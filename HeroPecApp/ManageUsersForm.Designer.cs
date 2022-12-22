
namespace HeroPecApp
{
    partial class ManageUsersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsersForm));
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.wrapPictureBox = new System.Windows.Forms.PictureBox();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.dragPanel = new System.Windows.Forms.PictureBox();
            this.loadPictureBox = new System.Windows.Forms.PictureBox();
            this.refreshPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrapPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AllowUserToDeleteRows = false;
            this.usersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.usersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Login,
            this.EMail,
            this.Password});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.usersDataGridView.EnableHeadersVisualStyles = false;
            this.usersDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.usersDataGridView.Location = new System.Drawing.Point(12, 32);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.usersDataGridView.RowHeadersVisible = false;
            this.usersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDataGridView.Size = new System.Drawing.Size(662, 380);
            this.usersDataGridView.TabIndex = 0;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "userid";
            this.Login.HeaderText = "Логин";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // EMail
            // 
            this.EMail.DataPropertyName = "email";
            this.EMail.HeaderText = "Эл. Почта";
            this.EMail.Name = "EMail";
            this.EMail.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "passwd";
            this.Password.HeaderText = "Пароль";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.addButton.Location = new System.Drawing.Point(108, 418);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(148, 47);
            this.addButton.TabIndex = 45;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.editButton.Location = new System.Drawing.Point(262, 418);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(148, 47);
            this.editButton.TabIndex = 46;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.deleteButton.Location = new System.Drawing.Point(416, 418);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(148, 47);
            this.deleteButton.TabIndex = 47;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // wrapPictureBox
            // 
            this.wrapPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wrapPictureBox.Image = global::HeroPecApp.Properties.Resources.wrap;
            this.wrapPictureBox.Location = new System.Drawing.Point(628, 2);
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
            this.exitPictureBox.Location = new System.Drawing.Point(658, 2);
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
            this.dragPanel.Location = new System.Drawing.Point(-19, -8);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(712, 34);
            this.dragPanel.TabIndex = 60;
            this.dragPanel.TabStop = false;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            this.dragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseMove);
            // 
            // loadPictureBox
            // 
            this.loadPictureBox.Image = global::HeroPecApp.Properties.Resources.logogif;
            this.loadPictureBox.Location = new System.Drawing.Point(15, 65);
            this.loadPictureBox.Name = "loadPictureBox";
            this.loadPictureBox.Size = new System.Drawing.Size(656, 344);
            this.loadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadPictureBox.TabIndex = 71;
            this.loadPictureBox.TabStop = false;
            this.loadPictureBox.Visible = false;
            // 
            // refreshPictureBox
            // 
            this.refreshPictureBox.Image = global::HeroPecApp.Properties.Resources.refresh;
            this.refreshPictureBox.Location = new System.Drawing.Point(628, 418);
            this.refreshPictureBox.Name = "refreshPictureBox";
            this.refreshPictureBox.Size = new System.Drawing.Size(43, 34);
            this.refreshPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshPictureBox.TabIndex = 72;
            this.refreshPictureBox.TabStop = false;
            this.refreshPictureBox.Click += new System.EventHandler(this.refreshPictureBox_Click);
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(686, 473);
            this.Controls.Add(this.refreshPictureBox);
            this.Controls.Add(this.loadPictureBox);
            this.Controls.Add(this.wrapPictureBox);
            this.Controls.Add(this.exitPictureBox);
            this.Controls.Add(this.dragPanel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.usersDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageUsersForm";
            this.Text = "HeroPec Управление пользователями";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrapPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.PictureBox wrapPictureBox;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.PictureBox dragPanel;
        private System.Windows.Forms.PictureBox loadPictureBox;
        private System.Windows.Forms.PictureBox refreshPictureBox;
    }
}