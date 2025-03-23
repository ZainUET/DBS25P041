using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DB_Mid_Project.BL;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class RemoveFacultyAdminRoles : Form
    {
        public RemoveFacultyAdminRoles()
        {
            InitializeComponent();
            LoadFacultyAdminRoles();
        }

        private void LoadFacultyAdminRoles()
        {
            List<RemoveFacultyAdminRolesBL> facultyAdminRoles = RemoveFacultyAdminRolesDL.GetFacultyAdminRoles();
            dataGridViewFacultyAdminRoles.DataSource = facultyAdminRoles;
            dataGridViewFacultyAdminRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        


        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FacultyAdminRoleManagement mainMenu = new FacultyAdminRoleManagement();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();

        }

        private void removeButton_Click_1(object sender, EventArgs e)
        {

            if (dataGridViewFacultyAdminRoles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a faculty admin role to remove.");
                return;
            }

            int adminRoleId = (int)dataGridViewFacultyAdminRoles.SelectedRows[0].Cells["AdminRoleId"].Value;

            if (RemoveFacultyAdminRolesDL.RemoveFacultyAdminRole(adminRoleId))
            {
                MessageBox.Show("Faculty admin role removed successfully!");
                LoadFacultyAdminRoles();
            }
            else
            {
                MessageBox.Show("Failed to remove faculty admin role.");
            }

        }
    }
}
