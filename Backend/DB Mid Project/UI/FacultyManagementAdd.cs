using System;
using System.Data;
using System.Windows.Forms;
using DB_Mid_Project.BL;

namespace DB_Mid_Project.UI
{
    public partial class FacultyManagementAdd : Form
    {
        private readonly FacultyManagementAddBL facultyBL;

        public FacultyManagementAdd()
        {
            InitializeComponent();
            facultyBL = new FacultyManagementAddBL();
        }

        private void FacultyManagementAdd_Load(object sender, EventArgs e)
        {
            LoadDesignations();
        }

        private void LoadDesignations()
        {
            try
            {
                DataTable dt = facultyBL.GetDesignations();
                Designation.DataSource = dt;
                Designation.DisplayMember = "value";
                Designation.ValueMember = "lookup_id";
                Designation.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading designations: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Designation.SelectedIndex == 0 || Designation.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a valid designation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string name = fname.Text.Trim();
                string email = femail.Text.Trim();
                string contact = fcontact.Text.Trim();
                int designationId = (int)Designation.SelectedValue;
                string researchArea = fResearchArea.Text.Trim();
                int teachingHours = int.Parse(fTeachingHours.Text.Trim());

                facultyBL.AddFaculty(name, email, contact, designationId, researchArea, teachingHours);

                MessageBox.Show("Faculty member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
