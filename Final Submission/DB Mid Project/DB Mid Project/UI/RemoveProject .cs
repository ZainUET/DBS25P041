using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class RemoveProject : Form
    {
        public RemoveProject()
        {
            InitializeComponent();
            LoadProjects();
        }

        private void LoadProjects()
        {
            try
            {
                projects.Items.Clear(); 
                List<KeyValuePair<int, string>> projectList = RemoveProjectDL.GetProjects();

                foreach (var project in projectList)
                {
                    projects.Items.Add(project);
                }

                projects.DisplayMember = "Value";
                projects.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add_course_Click(object sender, EventArgs e)
        {
            if (projects.SelectedItem == null)
            {
                MessageBox.Show("Please select a project to remove.");
                return;
            }

            int projectId = ((KeyValuePair<int, string>)projects.SelectedItem).Key;

            try
            {
                int rowsAffected = RemoveProjectDL.RemoveProject(projectId);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Project removed successfully!");
                    projects.Items.Remove(projects.SelectedItem);
                    LoadProjects();
                }
                else
                {
                    MessageBox.Show("Failed to remove project.");
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
