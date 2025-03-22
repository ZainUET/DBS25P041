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
    public partial class ProjectManagement : Form
    {
        public ProjectManagement()
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

            AddProject addForm = new AddProject();
            this.Hide();
            addForm.ShowDialog();
            this.Close();
        }

        private void removemember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            RemoveProject addForm = new RemoveProject();
            this.Hide();
            addForm.ShowDialog();
            this.Close();
        }

        private void updatemember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            UpdateProject updateForm = new UpdateProject();
            this.Hide();
            updateForm.ShowDialog();
            this.Close();
        }

        private void showfaculty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowProjects showForm = new ShowProjects();
            this.Hide();
            showForm.ShowDialog();
            this.Close();
        }
    }
}
