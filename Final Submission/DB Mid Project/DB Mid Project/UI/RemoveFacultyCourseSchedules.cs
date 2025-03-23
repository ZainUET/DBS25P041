using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DB_Mid_Project.BL;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class RemoveFacultyCourseSchedules : Form
    {
        private List<FacultyCourseScheduleBL> scheduleList;

        public RemoveFacultyCourseSchedules()
        {
            InitializeComponent();
            LoadFacultyCourseSchedules();
        }

        private void LoadFacultyCourseSchedules()
        {
            try
            {
                scheduleList = RemoveFacultyCourseSchedulesDL.GetFacultyCourseSchedules();
                dataGridViewFacultyCourseSchedules.DataSource = scheduleList;
                dataGridViewFacultyCourseSchedules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading faculty course schedules: " + ex.Message);
            }
        }    

        private void removeButton_Click_1(object sender, EventArgs e)
        {

            if (dataGridViewFacultyCourseSchedules.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a faculty course schedule to remove.");
                return;
            }

            int scheduleId = (int)dataGridViewFacultyCourseSchedules.SelectedRows[0].Cells["ScheduleId"].Value;

            try
            {
                bool isRemoved = RemoveFacultyCourseSchedulesDL.RemoveFacultyCourseSchedule(scheduleId);
                if (isRemoved)
                {
                    MessageBox.Show("Faculty course schedule removed successfully!");
                    LoadFacultyCourseSchedules(); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to remove faculty course schedule.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing faculty course schedule: " + ex.Message);
            }

        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FacultyCourseScheduleManagement mainMenu = new FacultyCourseScheduleManagement();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();

        }
    }
}
