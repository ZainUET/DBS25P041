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
    public partial class FacultyProjectManagement : Form
    {
        public FacultyProjectManagement()
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

            AssignProjectToFaculty addForm = new AssignProjectToFaculty();
            this.Hide();
            addForm.ShowDialog();
            this.Close();
        }

        private void removemember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            RemoveFacultyProjects addForm = new RemoveFacultyProjects();
            this.Hide();
            addForm.ShowDialog();
            this.Close();
        }

        

        private void showfaculty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowFacultyProjects showForm = new ShowFacultyProjects();
            this.Hide();
            showForm.ShowDialog();
            this.Close();
        }
    }
}
