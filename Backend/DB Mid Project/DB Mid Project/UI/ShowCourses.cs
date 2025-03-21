using System;
using System.Data;
using System.Windows.Forms;
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
                DataTable dt = ShowCoursesDL.GetCourses();
                courses.DataSource = dt;

                courses.Columns["course_id"].HeaderText = "Course ID";
                courses.Columns["course_name"].HeaderText = "Course Name";
                courses.Columns["course_type"].HeaderText = "Course Type";
                courses.Columns["credit_hours"].HeaderText = "Credit Hours";
                courses.Columns["contact_hours"].HeaderText = "Contact Hours";
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
