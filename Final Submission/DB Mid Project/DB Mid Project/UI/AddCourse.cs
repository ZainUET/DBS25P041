using System;
using System.Windows.Forms;
using DB_Mid_Project.DL;
using static DB_Mid_Project.DL.AddCourseDL;

namespace DB_Mid_Project.UI
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
            LoadCourseTypes();
        }

        private void LoadCourseTypes()
        {
            course_type.Items.Add("Theory");
            course_type.Items.Add("Lab");
            course_type.SelectedIndex = 0;
        }

        private void add_course_Click(object sender, EventArgs e)
        {
            string courseName = course_name.Text;
            string courseType = course_type.SelectedItem.ToString();
            int creditHours = int.Parse(credit_hours.Text);
            int contactHours = int.Parse(contact_hours.Text);

            try
            {
                int rowsAffected = CourseDL.AddCourse(courseName, courseType, creditHours, contactHours);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Course added successfully!");
                    NavigateToCourseManagement();
                }
                else
                {
                    MessageBox.Show("Failed to add course.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding course: " + ex.Message);
            }
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigateToCourseManagement();
        }

        private void NavigateToCourseManagement()
        {
            CourseManagement CMForm = new CourseManagement();
            this.Hide();
            CMForm.ShowDialog();
            this.Close();
        }
    }
}
