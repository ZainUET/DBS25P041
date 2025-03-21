using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class UpdateSemester : Form
    {
        public UpdateSemester()
        {
            InitializeComponent();
            LoadSemesters();
            LoadTerms();
        }

        private void LoadSemesters()
        {
            try
            {
                var semesterList = UpdateSemesterDL.GetSemesters();
                semesters.DataSource = new BindingSource(semesterList, null);
                semesters.DisplayMember = "Value";
                semesters.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadTerms()
        {
            newsemester.Items.AddRange(new string[] { "Spring", "Summer", "Fall" });
            newsemester.SelectedIndex = 0;
        }

        private void semesters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (semesters.SelectedItem == null)
                return;

            int semesterId = ((KeyValuePair<int, string>)semesters.SelectedItem).Key;
            LoadSemesterDetails(semesterId);
        }

        private void LoadSemesterDetails(int semesterId)
        {
            try
            {
                DataRow semesterData = UpdateSemesterDL.GetSemesterDetails(semesterId);
                if (semesterData != null)
                {
                    newsemester.SelectedItem = semesterData["term"].ToString();
                    year.Value = Convert.ToInt32(semesterData["year"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add_course_Click(object sender, EventArgs e)
        {
            if (semesters.SelectedItem == null)
            {
                MessageBox.Show("Please select a semester to update.");
                return;
            }

            int semesterId = ((KeyValuePair<int, string>)semesters.SelectedItem).Key;
            string term = newsemester.SelectedItem.ToString();
            int yearValue = (int)year.Value;

            try
            {
                int rowsAffected = UpdateSemesterDL.UpdateSemester(semesterId, term, yearValue);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Semester updated successfully!");

                    SemesterManagement semesterForm = new SemesterManagement();
                    this.Hide();
                    semesterForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update semester.");
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
