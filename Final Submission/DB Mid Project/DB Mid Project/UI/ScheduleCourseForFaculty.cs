using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DB_Mid_Project.BL;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class ScheduleCourseForFaculty : Form
    {
        public ScheduleCourseForFaculty()
        {
            InitializeComponent();
            LoadFaculty();
            LoadCourses();
            LoadRooms();
            LoadDaysOfWeek();
        }

        private void LoadFaculty()
        {
            facultyComboBox.DataSource = ScheduleCourseForFacultyDL.GetFaculty();
            facultyComboBox.DisplayMember = "Name";
            facultyComboBox.ValueMember = "Id";
        }

        private void LoadCourses()
        {
            courseComboBox.DataSource = ScheduleCourseForFacultyDL.GetCourses();
            courseComboBox.DisplayMember = "Name";
            courseComboBox.ValueMember = "Id";
        }

        private void LoadRooms()
        {
            roomComboBox.DataSource = ScheduleCourseForFacultyDL.GetRooms();
            roomComboBox.DisplayMember = "Name";
            roomComboBox.ValueMember = "Id";
        }

        private void LoadDaysOfWeek()
        {
            dayOfWeekComboBox.Items.AddRange(new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
            dayOfWeekComboBox.SelectedIndex = 0;
        }


        

        private void scheduleButton_Click_1(object sender, EventArgs e)
        {
            if (facultyComboBox.SelectedItem == null || courseComboBox.SelectedItem == null || roomComboBox.SelectedItem == null || dayOfWeekComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a faculty, course, room, and day of the week.");
                return;
            }

            int facultyId = (int)facultyComboBox.SelectedValue;
            int courseId = (int)courseComboBox.SelectedValue;
            int roomId = (int)roomComboBox.SelectedValue;
            string dayOfWeek = dayOfWeekComboBox.SelectedItem.ToString();
            TimeSpan startTime = startTimePicker.Value.TimeOfDay;
            TimeSpan endTime = endTimePicker.Value.TimeOfDay;

            if (ScheduleCourseForFacultyDL.ScheduleCourse(facultyId, courseId, roomId, dayOfWeek, startTime, endTime))
            {
                MessageBox.Show("Course scheduled for faculty successfully!");
            }
            else
            {
                MessageBox.Show("Failed to schedule course for faculty.");
            }

        }

        private void backLinkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FacultyCourseScheduleManagement mainMenu = new FacultyCourseScheduleManagement();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();

        }
    }
}
