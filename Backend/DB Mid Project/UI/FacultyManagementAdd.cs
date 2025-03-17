using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DB_Mid_Project.DL;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.UI
{
    public partial class FacultyManagementAdd : Form
    {
        public FacultyManagementAdd()
        {
            InitializeComponent();

        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

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

                            Designation.DataSource = dt;
                            Designation.DisplayMember = "value";  
                            Designation.ValueMember = "lookup_id";  

                            Designation.SelectedIndex = 0;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading designations: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FacultyManagementAdd_Load_1(object sender, EventArgs e)
        {
            LoadDesignations();

        }
        private void Submit_Click(object sender, EventArgs e)
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

            string query = "INSERT INTO faculty (name, email, contact, designation_id, research_area, total_teaching_hours, user_id) " +
                           "VALUES (@name, @email, @contact, @designationId, @researchArea, @teachingHours, @userId)";
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
                    command.Parameters.AddWithValue("@userId", null); 
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Faculty member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
