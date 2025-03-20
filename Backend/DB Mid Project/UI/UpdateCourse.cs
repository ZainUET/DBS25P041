using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DB_Mid_Project.DL; // Import the namespace where DatabaseHelper is defined

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
                string query = "SELECT course_id, course_name FROM courses";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    while (reader.Read())
                    {
                        
                        courses.Items.Add(new KeyValuePair<int, string>(
                            reader.GetInt32("course_id"), 
                            reader.GetString("course_name") 
                        ));
                    }
                }

                courses.DisplayMember = "Value";
                courses.ValueMember = "Key"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
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
                string query = $"SELECT course_name, course_type, credit_hours, contact_hours FROM courses WHERE course_id = {courseId}";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    if (reader.Read())
                    {
                        course_name.Text = reader.GetString("course_name");
                        course_type.SelectedItem = reader.GetString("course_type");
                        credit_hours.Text = reader.GetInt32("credit_hours").ToString();
                        contact_hours.Text = reader.GetInt32("contact_hours").ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading course details: " + ex.Message);
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
            int creditHours = int.Parse(credit_hours.Text);
            int contactHours = int.Parse(contact_hours.Text);

            try
            {
                string query = $"UPDATE courses SET course_name = '{courseName}', course_type = '{courseType}', " +
                                $"credit_hours = {creditHours}, contact_hours = {contactHours} " +
                                $"WHERE course_id = {courseId}";

                int rowsAffected = DatabaseHelper.Instance.Update(query);

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
                MessageBox.Show("Error updating course: " + ex.Message);
            }
        }

    }
}
