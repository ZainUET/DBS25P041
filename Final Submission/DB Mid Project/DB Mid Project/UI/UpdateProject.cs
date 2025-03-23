using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class UpdateProject : Form
    {
        public UpdateProject()
        {
            InitializeComponent();
            LoadProjects();
        }

        private void LoadProjects()
        {
            try
            {
                var projectsList = UpdateProjectDL.GetProjects();
                projects.DataSource = new BindingSource(projectsList, null);
                projects.DisplayMember = "Value";
                projects.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadProjectDetails(int projectId)
        {
            try
            {
                DataRow projectData = UpdateProjectDL.GetProjectDetails(projectId);
                if (projectData != null)
                {
                    course_name.Text = projectData["title"].ToString();
                    richTextBox1.Text = projectData["description"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void projects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (projects.SelectedItem == null)
                return;

            int projectId = ((KeyValuePair<int, string>)projects.SelectedItem).Key;
            LoadProjectDetails(projectId);
        }

        private void add_course_Click(object sender, EventArgs e)
        {
            if (projects.SelectedItem == null)
            {
                MessageBox.Show("Please select a project to update.");
                return;
            }

            int projectId = ((KeyValuePair<int, string>)projects.SelectedItem).Key;
            string title = course_name.Text;
            string description = richTextBox1.Text;

            try
            {
                int rowsAffected = UpdateProjectDL.UpdateProject(projectId, title, description);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Project updated successfully!");

                    ProjectManagement showForm = new ProjectManagement();
                    this.Hide();
                    showForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update project.");
                }
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
