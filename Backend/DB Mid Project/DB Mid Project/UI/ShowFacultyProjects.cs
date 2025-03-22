using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DB_Mid_Project.BL;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class ShowFacultyProjects : Form
    {
        public ShowFacultyProjects()
        {
            InitializeComponent();
            LoadFacultyProjects();
        }

        private void LoadFacultyProjects()
        {
            try
            {
                List<FacultyProject> facultyProjects = ShowFacultyProjectsBL.GetFacultyProjects();
                dataGridViewFacultyProjects.DataSource = facultyProjects;
                dataGridViewFacultyProjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading faculty-project assignments: " + ex.Message);
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
