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
    public partial class CourseManagement : Form
    {
        public CourseManagement()
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

            AddCourse addForm = new AddCourse();
            this.Hide();
            addForm.ShowDialog();
            this.Close();
        }

        private void removemember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            RemoveCourse removeForm = new RemoveCourse();
            this.Hide();
            removeForm.ShowDialog();
            this.Close();
        }

        private void updatemember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            UpdateCourse updateForm = new UpdateCourse();
            this.Hide();
            updateForm.ShowDialog();
            this.Close();
        }

        private void showfaculty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowCourses showForm = new ShowCourses();
            this.Hide();
            showForm.ShowDialog();
            this.Close();
        }
    }
}
