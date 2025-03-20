using System;
using System.Data;
using System.Windows.Forms;
using DB_Mid_Project.BL;

namespace DB_Mid_Project.UI
{
    public partial class FacultyManagementUpdate : Form
    {
        private readonly FacultyManagementUpdateBL facultyBL;

        public FacultyManagementUpdate()
        {
            InitializeComponent();
            facultyBL = new FacultyManagementUpdateBL();
        }

        private void FacultyManagementUpdate_Load(object sender, EventArgs e)
        {
            LoadFaculty();
            LoadDesignations();
        }

        private void LoadFaculty()
        {
            try
            {
                DataTable dt = facultyBL.GetFacultyList();
                cmbFaculty.DataSource = dt;
                cmbFaculty.DisplayMember = "name";
                cmbFaculty.ValueMember = "faculty_id";
                cmbFaculty.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading faculty members: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDesignations()
        {
            try
            {
                DataTable dt = facultyBL.GetDesignations();
                cmbDesignation.DataSource = dt;
                cmbDesignation.DisplayMember = "value";
                cmbDesignation.ValueMember = "lookup_id";
                cmbDesignation.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading designations: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedFacultyId = (int)cmbFaculty.SelectedValue;
                if (selectedFacultyId == -1)
                {
                    MessageBox.Show("Please select a faculty member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string name = txtName.Text.Trim();
                string email = txtEmail.Text.Trim();
                string contact = txtContact.Text.Trim();
                int designationId = (int)cmbDesignation.SelectedValue;
                string researchArea = txtResearchArea.Text.Trim();
                int teachingHours = int.Parse(txtTeachingHours.Text.Trim());

                facultyBL.UpdateFaculty(selectedFacultyId, name, email, contact, designationId, researchArea, teachingHours);

                MessageBox.Show("Faculty member updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FacultyManagement facultymanagement = new FacultyManagement();
                this.Hide();
                facultymanagement.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
