using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class RemoveCourse : Form
    {
        public RemoveCourse()
        {
            InitializeComponent();
            LoadCourses();
        }

        private void LoadCourses()
        {
            try
            {
                cmbcourses.Items.Clear(); 
                List<KeyValuePair<int, string>> courses = RemoveCourseDL.GetCourses();

                foreach (var course in courses)
                {
                    cmbcourses.Items.Add(course);
                }

                cmbcourses.DisplayMember = "Value";
                cmbcourses.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (cmbcourses.SelectedItem == null)
            {
                MessageBox.Show("Please select a course to remove.");
                return;
            }

            int courseId = ((KeyValuePair<int, string>)cmbcourses.SelectedItem).Key;

            try
            {
                int rowsAffected = RemoveCourseDL.RemoveCourse(courseId);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Course removed successfully!");
                    LoadCourses();
                    CourseManagement CMForm = new CourseManagement();
                    this.Hide();
                    CMForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to remove course.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CourseManagement CMForm = new CourseManagement();
            this.Hide();
            CMForm.ShowDialog();
            this.Close();
        }
    }
}
