using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DB_Mid_Project.DL; 
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

            // Use DatabaseHelper to execute the query
            try
            {
                string query = "INSERT INTO courses (course_name, course_type, credit_hours, contact_hours) " +
                               "VALUES (@courseName, @courseType, @creditHours, @contactHours)";

                // Create a MySqlCommand object and add parameters
                using (var connection = DatabaseHelper.Instance.getConnection())
                {
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@courseName", courseName);
                        cmd.Parameters.AddWithValue("@courseType", courseType);
                        cmd.Parameters.AddWithValue("@creditHours", creditHours);
                        cmd.Parameters.AddWithValue("@contactHours", contactHours);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Course added successfully!");

                            CourseManagement CMForm = new CourseManagement();
                            this.Hide();
                            CMForm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add course.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding course: " + ex.Message);
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