using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DB_Mid_Project.BL; // Import the Business Logic Layer

namespace DB_Mid_Project.UI
{
    public partial class AssignAdminRoleToFaculty : Form
    {
        public AssignAdminRoleToFaculty()
        {
            InitializeComponent();
            LoadFaculty();
            LoadRoles();
            LoadSemesters();
        }

        private void LoadFaculty()
        {
            try
            {
                facultyComboBox.Items.Clear();
                List<KeyValuePair<int, string>> facultyList = AssignAdminRoleToFacultyBL.GetFacultyList();

                foreach (var faculty in facultyList)
                {
                    facultyComboBox.Items.Add(faculty);
                }

                facultyComboBox.DisplayMember = "Value";
                facultyComboBox.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading faculty: " + ex.Message);
            }
        }

        private void LoadRoles()
        {
            try
            {
                roleComboBox.Items.Clear();
                List<string> roles = AssignAdminRoleToFacultyBL.GetRoles();

                foreach (string role in roles)
                {
                    roleComboBox.Items.Add(role);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading roles: " + ex.Message);
            }
        }

        private void LoadSemesters()
        {
            try
            {
                semesterComboBox.Items.Clear();
                List<KeyValuePair<int, string>> semesters = AssignAdminRoleToFacultyBL.GetSemesters();

                foreach (var semester in semesters)
                {
                    semesterComboBox.Items.Add(semester);
                }

                semesterComboBox.DisplayMember = "Value";
                semesterComboBox.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading semesters: " + ex.Message);
            }
        }



        

        private void allocateButton_Click(object sender, EventArgs e)
        {
            if (facultyComboBox.SelectedItem == null || roleComboBox.SelectedItem == null || semesterComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a faculty, role, and semester.");
                return;
            }

            int facultyId = ((KeyValuePair<int, string>)facultyComboBox.SelectedItem).Key;
            string roleName = roleComboBox.SelectedItem.ToString();
            int semesterId = ((KeyValuePair<int, string>)semesterComboBox.SelectedItem).Key;

            try
            {
                bool success = AssignAdminRoleToFacultyBL.AssignAdminRole(facultyId, roleName, semesterId);

                if (success)
                {
                    MessageBox.Show("Admin role assigned to faculty successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to assign admin role.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error assigning admin role: " + ex.Message);
            }
        }

        private void backLinkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FacultyAdminRoleManagement mainMenu = new FacultyAdminRoleManagement();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();

        }
    }
}
