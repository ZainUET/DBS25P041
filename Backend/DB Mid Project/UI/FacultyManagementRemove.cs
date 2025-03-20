using System;
using System.Data;
using System.Windows.Forms;
using DB_Mid_Project.BL;

namespace DB_Mid_Project.UI
{
    public partial class FacultyManagementRemove : Form
    {
        private readonly FacultyManagementRemoveBL facultyBL;

        public FacultyManagementRemove()
        {
            InitializeComponent();
            facultyBL = new FacultyManagementRemoveBL();
        }

        private void FacultyManagementRemove_Load(object sender, EventArgs e)
        {
            LoadFaculty();
        }

        private void LoadFaculty()
        {
            try
            {
                DataTable dt = facultyBL.GetFacultyList();
                Members.DataSource = dt;
                Members.DisplayMember = "name";
                Members.ValueMember = "faculty_id";
                Members.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading faculty members: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int facultyId = (int)Members.SelectedValue;

                DialogResult result = MessageBox.Show("Are you sure you want to delete this faculty member?",
                                                      "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    facultyBL.RemoveFaculty(facultyId);

                    MessageBox.Show("Faculty member deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFaculty();

                    FacultyManagement facultymanagement = new FacultyManagement();
                    this.Hide();
                    facultymanagement.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
