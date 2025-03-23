using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class RemoveSemester : Form
    {
        public RemoveSemester()
        {
            InitializeComponent();
            LoadSemesters();
        }

        private void LoadSemesters()
        {
            try
            {
                semesters.Items.Clear(); // Clear previous items
                List<KeyValuePair<int, string>> semesterList = RemoveSemesterDL.GetSemesters();

                foreach (var semester in semesterList)
                {
                    semesters.Items.Add(semester);
                }

                semesters.DisplayMember = "Value";
                semesters.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (semesters.SelectedItem == null)
            {
                MessageBox.Show("Please select a semester to remove.");
                return;
            }

            int semesterId = ((KeyValuePair<int, string>)semesters.SelectedItem).Key;

            try
            {
                int rowsAffected = RemoveSemesterDL.RemoveSemester(semesterId);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Semester removed successfully!");
                    semesters.Items.Remove(semesters.SelectedItem);
                    LoadSemesters(); // Refresh the list
                }
                else
                {
                    MessageBox.Show("Failed to remove semester.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SemesterManagement semesterForm = new SemesterManagement();
            this.Hide();
            semesterForm.ShowDialog();
            this.Close();
        }
    }
}
