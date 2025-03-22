using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Mid_Project.UI
{
    public partial class FacultyAdminRoleManagement : Form
    {
        public FacultyAdminRoleManagement()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DepartmentHeadDashborad AMForm = new DepartmentHeadDashborad();
            this.Hide();
            AMForm.ShowDialog();
            this.Close();
        }

        private void addmember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            AssignAdminRoleToFaculty addForm = new AssignAdminRoleToFaculty();
            this.Hide();
            addForm.ShowDialog();
            this.Close();
        }

        private void removemember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            RemoveFacultyAdminRoles addForm = new RemoveFacultyAdminRoles();
            this.Hide();
            addForm.ShowDialog();
            this.Close();
        }

        

        private void showfaculty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewFacultyAdminRoles showForm = new ViewFacultyAdminRoles();
            this.Hide();
            showForm.ShowDialog();
            this.Close();
        }
    }
}
