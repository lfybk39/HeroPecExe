using HeroPecApp.ConnectionFTP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroPecApp
{
    public partial class ManageUsersForm : Form
    {
        private Point windowPoint = new Point();

        private void ChangeState(bool enabled)
        {
            string[] ctrls = { "usersDataGridView", "exitPictureBox", "wrapPictureBox", "dragPanel" };
            foreach (Control control in Controls)
            {
                if (!ctrls.Contains(control.Name))
                {
                    control.Enabled = enabled;
                }
            }
            loadPictureBox.Enabled = loadPictureBox.Visible = !enabled;
        }

        private List<User> FillDataGridView()
        {
            try
            {
                return Core.Context.User.ToList();
            }
            catch (Exception ex)
            {
                HeroMessageBox.Show(ex.Message);
                return null;
            }
        }

        public ManageUsersForm()
        {
            var intro = new IntroForm();
            intro.Show();
            InitializeComponent();
            intro.Close();
            this.Icon = HeroPecApp.Properties.Resources.optionicon;
            usersDataGridView.AutoGenerateColumns = false;
        }

        private async void UsersForm_Load(object sender, EventArgs e)
        {
            try
            {
                ChangeState(false);
                usersDataGridView.DataSource = await Task.Run(() => FillDataGridView());
                ChangeState(true);
            }
            catch (Exception ex)
            {
                HeroMessageBox.Show(ex.Message);
                Close();
            }
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (usersDataGridView.SelectedRows.Count > 0)
            {
                ChangeState(false);
                await Task.Run(() => DeleteUser());
                usersDataGridView.DataSource = await Task.Run(() => FillDataGridView());
                ChangeState(true);
            }
        }

        private void DeleteUser()
        {
            for (int i = 0; i < usersDataGridView.SelectedRows.Count; i++)
            {
                Core.Context.User.Remove(usersDataGridView.SelectedRows[i].DataBoundItem as User);
                Core.Context.SaveChanges();
            }
            HeroMessageBox.Show($"Кол-во удаленных строк: {usersDataGridView.SelectedRows.Count}", "Успех!");
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            if (new UserForm().ShowDialog() == DialogResult.OK)
            {
                ChangeState(false);
                usersDataGridView.DataSource = await Task.Run(() => FillDataGridView());
                ChangeState(true);
            }
        }

        private async void editButton_Click(object sender, EventArgs e)
        {
            if (usersDataGridView.SelectedRows.Count > 0)
            {
                var user = usersDataGridView.SelectedRows[0].DataBoundItem as User;
                if (new UserForm(Core.Context.User.FirstOrDefault(u => u.userid == user.userid)).ShowDialog() == DialogResult.OK)
                {
                    ChangeState(false);
                    usersDataGridView.DataSource = await Task.Run(() => FillDataGridView());
                    ChangeState(true);
                }
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

        private void wrapPictureBox_MouseHover(object sender, EventArgs e)
        {
            wrapPictureBox.Image = Properties.Resources.minimize_hover;
        }

        private void wrapPictureBox_MouseLeave(object sender, EventArgs e)
        {
            wrapPictureBox.Image = Properties.Resources.wrap;
        }
        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void wrapPictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
    }
}
