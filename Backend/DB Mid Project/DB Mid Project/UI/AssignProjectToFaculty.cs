using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DB_Mid_Project.BL;

namespace DB_Mid_Project.UI
{
    public partial class AssignProjectToFaculty : Form
    {
        public AssignProjectToFaculty()
        {
            InitializeComponent();
            LoadFaculty();
            LoadProjects();
            LoadSemesters();
        }

        private void LoadFaculty()
        {
            facultyComboBox.Items.Clear();
            List<KeyValuePair<int, string>> facultyList = AssignProjectToFacultyBL.GetFaculty();

            foreach (var faculty in facultyList)
            {
                facultyComboBox.Items.Add(faculty);
            }

            facultyComboBox.DisplayMember = "Value";
            facultyComboBox.ValueMember = "Key";
        }

        private void LoadProjects()
        {
            projectComboBox.Items.Clear();
            List<KeyValuePair<int, string>> projectList = AssignProjectToFacultyBL.GetProjects();

            foreach (var project in projectList)
            {
                projectComboBox.Items.Add(project);
            }

            projectComboBox.DisplayMember = "Value";
            projectComboBox.ValueMember = "Key";
        }

        private void LoadSemesters()
        {
            semesterComboBox.Items.Clear();
            List<KeyValuePair<int, string>> semesterList = AssignProjectToFacultyBL.GetSemesters();

            foreach (var semester in semesterList)
            {
                semesterComboBox.Items.Add(semester);
            }

            semesterComboBox.DisplayMember = "Value";
            semesterComboBox.ValueMember = "Key";
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            if (facultyComboBox.SelectedItem == null || projectComboBox.SelectedItem == null || semesterComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a faculty, project, and semester.");
                return;
            }

            int facultyId = ((KeyValuePair<int, string>)facultyComboBox.SelectedItem).Key;
            int projectId = ((KeyValuePair<int, string>)projectComboBox.SelectedItem).Key;
            int semesterId = ((KeyValuePair<int, string>)semesterComboBox.SelectedItem).Key;
            int supervisionHours = (int)supervisionHoursNumericUpDown.Value;

            bool success = AssignProjectToFacultyBL.AssignProject(facultyId, projectId, semesterId, supervisionHours);

            if (success)
            {
                MessageBox.Show("Project assigned to faculty successfully!");
            }
            else
            {
                MessageBox.Show("Failed to assign project to faculty.");
            }
        }

        

        private void backLinkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FacultyProjectManagement mainMenu = new FacultyProjectManagement();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();

        }
    }
}
