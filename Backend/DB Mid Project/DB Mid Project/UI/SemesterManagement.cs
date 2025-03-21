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
    public partial class SemesterManagement : Form
    {
        public SemesterManagement()
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

            AddSemester addForm = new AddSemester();
            this.Hide();
            addForm.ShowDialog();
            this.Close();
        }

        private void removemember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            RemoveSemester removeForm = new RemoveSemester();
            this.Hide();
            removeForm.ShowDialog();
            this.Close();
        }

        private void updatemember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            UpdateSemester updateForm = new UpdateSemester();
            this.Hide();
            updateForm.ShowDialog();
            this.Close();
        }

        private void showfaculty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowSemesters showForm = new ShowSemesters();
            this.Hide();
            showForm.ShowDialog();
            this.Close();
        }
    }
}
