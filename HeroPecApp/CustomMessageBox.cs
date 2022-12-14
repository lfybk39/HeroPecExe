using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroPecApp
{
    internal partial class CustomMessageBox : Form
    {
        private Point windowPoint = new Point();

        public CustomMessageBox()
        {
            InitializeComponent();
            this.Icon = HeroPecApp.Properties.Resources.optionicon;
        }

        public CustomMessageBox(string message, string header= "Heropec Cloud")
        {
            InitializeComponent();
            this.Icon = HeroPecApp.Properties.Resources.optionicon;
            this.messageLabel.Text = message;
            this.headerLabel.Text = header;
            this.okButton.Visible = true;
        }

        public CustomMessageBox(string message, MessageBoxButtons buttons)
        {
            InitializeComponent();
            this.Icon = HeroPecApp.Properties.Resources.optionicon;
            this.messageLabel.Text = message;
            this.yesButton.Visible = noButton.Visible = true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            windowPoint = new Point(e.X, e.Y);
        }

        private void dragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - windowPoint.X, this.Location.Y + e.Y - windowPoint.Y);
            }
        }

        private void exitPictureBox_MouseHover(object sender, EventArgs e)
        {
            exitPictureBox.Image = Properties.Resources.exit_hover;
        }

        private void exitPictureBox_MouseLeave(object sender, EventArgs e)
        {
            exitPictureBox.Image = Properties.Resources.exit;
        }
    }

}
