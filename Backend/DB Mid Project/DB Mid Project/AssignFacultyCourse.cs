using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class AssignFacultyCourse : Form
    {
        public AssignFacultyCourse()
        {
            InitializeComponent();
            LoadFaculty();
            LoadCourses();
            LoadSemesters();
        }

        private void LoadFaculty()
        {
            try
            {
                facultyComboBox.Items.Clear();
                foreach (var faculty in FacultyCourseDL.GetFacultyList())
                {
                    facultyComboBox.Items.Add(faculty);
                }
                facultyComboBox.DisplayMember = "Value";
                facultyComboBox.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadCourses()
        {
            try
            {
                courseComboBox.Items.Clear();
                foreach (var course in FacultyCourseDL.GetCourseList())
                {
                    courseComboBox.Items.Add(course);
                }
                courseComboBox.DisplayMember = "Value";
                courseComboBox.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadSemesters()
        {
            try
            {
                semesterComboBox.Items.Clear();
                foreach (var semester in FacultyCourseDL.GetSemesterList())
                {
                    semesterComboBox.Items.Add(semester);
                }
                semesterComboBox.DisplayMember = "Value";
                semesterComboBox.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void assignButton_Click_1(object sender, EventArgs e)
        {
            if (facultyComboBox.SelectedItem == null || courseComboBox.SelectedItem == null || semesterComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a faculty, course, and semester.");
                return;
            }

            int facultyId = ((KeyValuePair<int, string>)facultyComboBox.SelectedItem).Key;
            int courseId = ((KeyValuePair<int, string>)courseComboBox.SelectedItem).Key;
            int semesterId = ((KeyValuePair<int, string>)semesterComboBox.SelectedItem).Key;

            try
            {
                int rowsAffected = FacultyCourseDL.AssignCourseToFaculty(facultyId, courseId, semesterId);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Course assigned to faculty successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to assign course to faculty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backLinkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FacultyCoursesManagement mainMenu = new FacultyCoursesManagement();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();
        }
    }
}
