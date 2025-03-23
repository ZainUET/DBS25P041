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
    public partial class DepartmentHeadDashborad : Form
    {
        public DepartmentHeadDashborad()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Login loginForm = new Login();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();

        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ApproveRejectRequests loginForm = new ApproveRejectRequests();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ProjectManagement loginForm = new ProjectManagement();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            RoomManagement loginForm = new RoomManagement();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FacultyAdminRoleManagement loginForm = new FacultyAdminRoleManagement();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();

        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FacultyCourseScheduleManagement loginForm = new FacultyCourseScheduleManagement();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();


        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reports loginForm = new Reports();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();


        }
    }
}
