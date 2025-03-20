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
    public partial class FacultyManagementRemove : Form
    {
        public FacultyManagementRemove()
        {
            InitializeComponent();
        }

        private void FacultyManagementRemove_Load(object sender, EventArgs e)
        {
            LoadFaculty();

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
                    Members.DataSource = dt;
                    Members.DisplayMember = "name"; // Display the faculty member's name
                    Members.ValueMember = "faculty_id"; // Use the faculty_id as the value

                    // Set the default selection to the placeholder
                    Members.SelectedIndex = 0;
                }
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error loading faculty members: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

        private void Delete_Click(object sender, EventArgs e)
        {
         
            int facultyId = (int)Members.SelectedValue;  

             
            DialogResult result = MessageBox.Show("Are you sure you want to delete this faculty member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM faculty WHERE faculty_id = @facultyId";
                using (var connection = DatabaseHelper.Instance.getConnection())
                {
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@facultyId", facultyId);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Faculty member deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFaculty();
                FacultyManagement facultymanagement = new FacultyManagement();
                this.Hide();
                facultymanagement.ShowDialog();
                this.Close();
            }

        
    }
    }
}
