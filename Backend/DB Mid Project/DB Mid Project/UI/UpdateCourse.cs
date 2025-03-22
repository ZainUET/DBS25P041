using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class UpdateCourse : Form
    {
        public UpdateCourse()
        {
            InitializeComponent();
            LoadCourses();
            LoadCourseTypes();
        }

        private void LoadCourses()
        {
            try
            {
                var coursesList = UpdateCourseDL.GetCourses();
                courses.DataSource = new BindingSource(coursesList, null);
                courses.DisplayMember = "Value";
                courses.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadCourseTypes()
        {
            course_type.Items.Add("Theory");
            course_type.Items.Add("Lab");
            course_type.SelectedIndex = 0;
        }

        private void comboBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (courses.SelectedItem == null)
                return;

            int courseId = ((KeyValuePair<int, string>)courses.SelectedItem).Key;
            LoadCourseDetails(courseId);
        }

        private void LoadCourseDetails(int courseId)
        {
            try
            {
                DataRow courseData = UpdateCourseDL.GetCourseDetails(courseId);
                if (courseData != null)
                {
                    course_name.Text = courseData["course_name"].ToString();
                    course_type.SelectedItem = courseData["course_type"].ToString();
                    credit_hours.Text = courseData["credit_hours"].ToString();
                    contact_hours.Text = courseData["contact_hours"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add_course_Click(object sender, EventArgs e)
        {
            if (courses.SelectedItem == null)
            {
                MessageBox.Show("Please select a course to update.");
                return;
            }

            int courseId = ((KeyValuePair<int, string>)courses.SelectedItem).Key;
            string courseName = course_name.Text;
            string courseType = course_type.SelectedItem.ToString();
            int creditHours, contactHours;

            if (!int.TryParse(credit_hours.Text, out creditHours) || !int.TryParse(contact_hours.Text, out contactHours))
            {
                MessageBox.Show("Please enter valid numeric values for credit and contact hours.");
                return;
            }

            try
            {
                int rowsAffected = UpdateCourseDL.UpdateCourse(courseId, courseName, courseType, creditHours, contactHours);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Course updated successfully!");
                    CourseManagement CMForm = new CourseManagement();
                    this.Hide();
                    CMForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update course.");
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
