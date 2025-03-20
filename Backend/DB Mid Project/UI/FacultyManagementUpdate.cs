using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Mid_Project.DL;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.UI
{
    public partial class FacultyManagementUpdate : Form
    {
        public FacultyManagementUpdate()
        {
            InitializeComponent();
        }




        private void LoadFaculty()
        {
            try
            {
                string query = "SELECT faculty_id, name FROM faculty";
                using (var connection = DatabaseHelper.Instance.getConnection())
                {
                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            // Add a placeholder row at the beginning of the DataTable
                            DataRow emptyRow = dt.NewRow();
                            emptyRow["name"] = "Select Faculty"; // Placeholder text
                            emptyRow["faculty_id"] = -1; // Use a unique value for the placeholder
                            dt.Rows.InsertAt(emptyRow, 0); // Insert at the top of the DataTable

                            // Bind the DataTable to the ComboBox
                            cmbFaculty.DataSource = dt;
                            cmbFaculty.DisplayMember = "name"; // Display the faculty member's name
                            cmbFaculty.ValueMember = "faculty_id"; // Use the faculty_id as the value

                            // Set the default selection to the placeholder
                            cmbFaculty.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading faculty members: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    int selectedFacultyId = (int)cmbFaculty.SelectedValue;

        //    // Check if the placeholder is selected
        //    if (selectedFacultyId == -1)
        //    {
        //        // Clear the form fields
        //        ClearForm();
        //        return;
        //    }

        //    // Fetch faculty details from the database
        //    string query = "SELECT name, email, contact, designation_id, research_area, total_teaching_hours FROM faculty WHERE faculty_id = @facultyId";
        //    using (var connection = DatabaseHelper.Instance.getConnection())
        //    {
        //        using (var command = new MySqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@facultyId", selectedFacultyId);
        //            using (var reader = command.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    // Populate the form fields
        //                    txtName.Text = reader["name"].ToString();
        //                    txtEmail.Text = reader["email"].ToString();
        //                    txtContact.Text = reader["contact"].ToString();
        //                    cmbDesignation.SelectedValue = reader["designation_id"];
        //                    txtResearchArea.Text = reader["research_area"].ToString();
        //                    txtTeachingHours.Text = reader["total_teaching_hours"].ToString();
        //                }
        //            }
        //        }
        //    }
        //}

        private void ClearForm()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            cmbDesignation.SelectedIndex = -1;
            txtResearchArea.Clear();
            txtTeachingHours.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            int selectedFacultyId = (int)cmbFaculty.SelectedValue;

            // Check if the placeholder is selected
            if (selectedFacultyId == -1)
            {
                MessageBox.Show("Please select a faculty member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get updated details from the form
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string contact = txtContact.Text.Trim();
            int designationId = (int)cmbDesignation.SelectedValue;
            string researchArea = txtResearchArea.Text.Trim();
            int teachingHours = int.Parse(txtTeachingHours.Text.Trim());

            // Update the faculty member in the database
            string query = "UPDATE faculty SET name = @name, email = @email, contact = @contact, designation_id = @designationId, research_area = @researchArea, total_teaching_hours = @teachingHours WHERE faculty_id = @facultyId";
            using (var connection = DatabaseHelper.Instance.getConnection())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@contact", contact);
                    command.Parameters.AddWithValue("@designationId", designationId);
                    command.Parameters.AddWithValue("@researchArea", researchArea);
                    command.Parameters.AddWithValue("@teachingHours", teachingHours);
                    command.Parameters.AddWithValue("@facultyId", selectedFacultyId);
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Faculty member updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FacultyManagement facultymanagement = new FacultyManagement();
            this.Hide();
            facultymanagement.ShowDialog();
            this.Close();
        }

        private void LoadDesignations()
        {
         
            try
            {
                string query = "SELECT lookup_id, value FROM lookup WHERE category = 'Designations'";
                using (var connection = DatabaseHelper.Instance.getConnection())
                {
                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            DataRow emptyRow = dt.NewRow();
                            emptyRow["value"] = "Select Designation";
                            emptyRow["lookup_id"] = -1;
                            dt.Rows.InsertAt(emptyRow, 0);

                            cmbDesignation.DataSource = dt;
                            cmbDesignation.DisplayMember = "value";
                            cmbDesignation.ValueMember = "lookup_id";

                            cmbDesignation.SelectedIndex = 0;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading designations: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void FacultyManagementUpdate_Load(object sender, EventArgs e)
        {
            LoadFaculty();
            LoadDesignations();
        }
    }
}


