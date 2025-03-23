using System;
using System.Data;
using System.Windows.Forms;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class ShowProjects : Form
    {
        public ShowProjects()
        {
            InitializeComponent();
            LoadProjectData();
        }

        private void LoadProjectData()
        {
            try
            {
                DataTable dt = ShowProjectsDL.GetProjects();
                projects.DataSource = dt;

                projects.Columns["project_id"].HeaderText = "Project ID";
                projects.Columns["title"].HeaderText = "Title";
                projects.Columns["description"].HeaderText = "Description";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProjectManagement showForm = new ProjectManagement();
            this.Hide();
            showForm.ShowDialog();
            this.Close();
        }
    }
}
