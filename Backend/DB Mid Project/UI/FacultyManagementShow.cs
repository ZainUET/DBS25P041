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
    public partial class FacultyManagementShow : Form
    {
        public FacultyManagementShow()
        {
            InitializeComponent();
            LoadFacultyData();
        }



        private void LoadFacultyData()
        {
            try
            {
                // Query to fetch all faculty details
                string query = @"
                    SELECT 
                        faculty_id AS 'Faculty ID',
                        name AS 'Name',
                        email AS 'Email',
                        contact AS 'Contact',
                        designation_id AS 'Designation ID',
                        research_area AS 'Research Area',
                        total_teaching_hours AS 'Teaching Hours'
                    FROM faculty";

                using (var connection = DatabaseHelper.Instance.getConnection())
                {
                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt); // Fill the DataTable with faculty data

                            // Bind the DataTable to the DataGridView
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading faculty data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Refresh the data when the button is clicked
            LoadFacultyData();
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FacultyManagement facultymanagement = new FacultyManagement();
            this.Hide();
            facultymanagement.ShowDialog();
            this.Close();

        }
    }
}




















