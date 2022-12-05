using HeroPecApp.ConnectionFTP;
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
    public partial class ManageUsersForm : Form
    {
        private void FillDataGridView()
        {
            usersDataGridView.DataSource = Core.Context.User.ToList();
        }

        public ManageUsersForm()
        {
            InitializeComponent();
            usersDataGridView.AutoGenerateColumns = false;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (usersDataGridView.SelectedRows.Count > 0)
            {
                for (int i = 0; i < usersDataGridView.SelectedRows.Count; i++)
                {
                    Core.Context.User.Remove(usersDataGridView.SelectedRows[i].DataBoundItem as User);
                    Core.Context.SaveChanges();
                }
                MessageBox.Show($"Кол-во удаленных строк: {usersDataGridView.SelectedRows.Count}", "Успех!", MessageBoxButtons.OK);
                FillDataGridView();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (new UserForm().ShowDialog() == DialogResult.OK)
            {
                FillDataGridView();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (usersDataGridView.SelectedRows.Count > 0)
            {
                var user = usersDataGridView.SelectedRows[0].DataBoundItem as User;
                if (new UserForm(Core.Context.User.FirstOrDefault(u => u.userid == user.userid)).ShowDialog() == DialogResult.OK)
                {
                    FillDataGridView();
                }
            }
        }
    }
}
