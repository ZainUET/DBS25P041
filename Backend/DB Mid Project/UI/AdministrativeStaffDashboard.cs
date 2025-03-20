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
    public partial class AdministrativeStaffDashboard : Form
    {
        public AdministrativeStaffDashboard()
        {
            InitializeComponent();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FacultyManagement faculty = new FacultyManagement();
            this.Hide();
            faculty.ShowDialog();
            this.Close();
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Login loginForm = new Login();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            CourseManagement CourseForm = new CourseManagement();
            this.Hide();
            CourseForm.ShowDialog();
            this.Close();
        }
    }
}
