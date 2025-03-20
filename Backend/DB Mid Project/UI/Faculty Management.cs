using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Mid_Project.UI;

namespace DB_Mid_Project
{
    public partial class FacultyManagement : Form
    {
        public FacultyManagement()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void addmember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FacultyManagementAdd facultyadd = new FacultyManagementAdd();
            this.Hide();
            facultyadd.ShowDialog();
            this.Close();

        }

        private void removemember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FacultyManagementRemove facultyremove = new FacultyManagementRemove();
            this.Hide();
            facultyremove.ShowDialog();
            this.Close();

        }

        private void updatemember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FacultyManagementUpdate facultyupdate = new FacultyManagementUpdate();
            this.Hide();
            facultyupdate.ShowDialog();
            this.Close();

        }

        private void showfaculty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FacultyManagementShow facultyshow = new FacultyManagementShow();
            this.Hide();
            facultyshow.ShowDialog();
            this.Close();
        }

        private void Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdministrativeStaffDashboard adminndashboard = new AdministrativeStaffDashboard();
            this.Hide();
            adminndashboard.ShowDialog();
            this.Close();
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Login loginForm = new Login();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
