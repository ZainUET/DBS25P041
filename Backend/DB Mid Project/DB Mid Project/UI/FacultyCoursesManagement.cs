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
    public partial class FacultyCoursesManagement : Form
    {
        public FacultyCoursesManagement()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdministrativeStaffDashboard AMForm = new AdministrativeStaffDashboard();
            this.Hide();
            AMForm.ShowDialog();
            this.Close();
        }

        private void addmember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            AssignFacultyCourse addForm = new AssignFacultyCourse();
            this.Hide();
            addForm.ShowDialog();
            this.Close();
        }

        private void removemember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            RemoveFacultyCourse addForm = new RemoveFacultyCourse();
            this.Hide();
            addForm.ShowDialog();
            this.Close();
        }

        

        private void showfaculty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewAssignedFacultyCourses showForm = new ViewAssignedFacultyCourses();
            this.Hide();
            showForm.ShowDialog();
            this.Close();
        }
    }
}
