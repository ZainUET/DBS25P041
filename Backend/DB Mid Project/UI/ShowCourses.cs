using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DB_Mid_Project.DL; 

namespace DB_Mid_Project.UI
{
    public partial class ShowCourses : Form
    {
        public ShowCourses()
        {
            InitializeComponent();
            LoadCourseData();
        }

        private void LoadCourseData()
        {
            try
            {
                string query = "SELECT course_id, course_name, course_type, credit_hours, contact_hours FROM courses";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    courses.DataSource = dt;

                    courses.Columns["course_id"].HeaderText = "Course ID";
                    courses.Columns["course_name"].HeaderText = "Course Name";
                    courses.Columns["course_type"].HeaderText = "Course Type";
                    courses.Columns["credit_hours"].HeaderText = "Credit Hours";
                    courses.Columns["contact_hours"].HeaderText = "Contact Hours";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading course data: " + ex.Message);
            }
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CourseManagement CMForm = new CourseManagement();
            this.Hide();
            CMForm.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}