using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DB_Mid_Project.BL;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class ViewFacultyAdminRoles : Form
    {
        public ViewFacultyAdminRoles()
        {
            InitializeComponent();
            LoadFacultyAdminRoles();
        }

        private void LoadFacultyAdminRoles()
        {
            List<ViewFacultyAdminRolesBL> facultyAdminRoles = ViewFacultyAdminRolesDL.GetFacultyAdminRoles();
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
    }
}
