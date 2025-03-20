using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
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
                string query = "SELECT course_id, course_name FROM courses";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    while (reader.Read())
                    {
                        cmbcourses.Items.Add(new KeyValuePair<int, string>(
                            reader.GetInt32("course_id"),
                            reader.GetString("course_name")
                        ));
                    }
                }

                cmbcourses.DisplayMember = "Value";
                cmbcourses.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
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
                string query = $"DELETE FROM courses WHERE course_id = {courseId}";
                int rowsAffected = DatabaseHelper.Instance.Update(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Course removed successfully!");
                    cmbcourses.Items.Remove(cmbcourses.SelectedItem);

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
                MessageBox.Show("Error removing course: " + ex.Message);
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