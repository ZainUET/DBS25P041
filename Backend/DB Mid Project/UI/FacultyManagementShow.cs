using System.Data;
using DB_Mid_Project.BL;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.UI
{
    public partial class FacultyManagementShow : Form
    {

        private readonly FacultyMangementShowBL facultyBLL;

        public FacultyManagementShow()
        {
            InitializeComponent();
            string connectionString = "server=127.0.0.1;port=3306;user=root;database=midprojectdb;password=zain.8773;SslMode=None;"; // Replace with your actual connection string
            facultyBLL = new FacultyMangementShowBL(connectionString);
            LoadFacultyData();
        }

        private void LoadFacultyData()
        {
            try
            {
                DataTable dt = facultyBLL.GetAllFaculty();
                dvgFaculty.DataSource = dt;

                // Optional: Customize the DataGridView
                dvgFaculty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dvgFaculty.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading faculty data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            facultyBLL.GetAllFaculty();
        }




        

        private void logout_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FacultyManagement facultymanagement = new FacultyManagement();
            this.Hide();
            facultymanagement.ShowDialog();
            this.Close();
        }
    }
}


