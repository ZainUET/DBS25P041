using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DB_Mid_Project.BL;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class RemoveFacultyProjects : Form
    {
        public RemoveFacultyProjects()
        {
            InitializeComponent();
            LoadFacultyProjects();
        }

        private void LoadFacultyProjects()
        {
            try
            {
                List<FacultyProject> facultyProjects = RemoveFacultyProjectsBL.GetFacultyProjects();
                dataGridViewFacultyProjects.DataSource = facultyProjects;
                dataGridViewFacultyProjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading faculty-project assignments: " + ex.Message);
            }
        }





        

        private void removeButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewFacultyProjects.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a faculty-project assignment to remove.");
                return;
            }

            int facultyProjectId = (int)dataGridViewFacultyProjects.SelectedRows[0].Cells["FacultyProjectId"].Value;

            try
            {
                bool success = RemoveFacultyProjectsBL.RemoveFacultyProject(facultyProjectId);

                if (success)
                {
                    MessageBox.Show("Faculty-project assignment removed successfully!");
                    LoadFacultyProjects();
                }
                else
                {
                    MessageBox.Show("Failed to remove faculty-project assignment.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing faculty-project assignment: " + ex.Message);
            }

        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FacultyProjectManagement mainMenu = new FacultyProjectManagement();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();
        }
    }
}