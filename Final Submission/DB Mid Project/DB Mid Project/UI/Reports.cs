using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;
using DB_Mid_Project.DL; // Import the namespace where DatabaseHelper is defined

namespace DB_Mid_Project.UI
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            LoadReportTypes();
        }

        private void LoadReportTypes()
        {
            reportTypeComboBox.Items.Add("Faculty with Assigned Courses");
            reportTypeComboBox.Items.Add("Rooms Allocated by Semester");
            reportTypeComboBox.Items.Add("Faculty Admin Roles");
            reportTypeComboBox.Items.Add("Courses Offered in Each Semester");
            reportTypeComboBox.SelectedIndex = 0;
        }



        private DataTable GetFacultyCourseAssignments()
        {
            string query = @"
                SELECT f.name AS Faculty, c.course_name AS Course
                FROM faculty_courses fc
                JOIN faculty f ON fc.faculty_id = f.faculty_id
                JOIN courses c ON fc.course_id = c.course_id";
            return DatabaseHelper.Instance.GetData(query);
        }

        private DataTable GetRoomsAllocatedBySemester()
        {
            string query = @"
                SELECT s.term AS Term, s.year AS Year, r.room_name AS Room
                FROM faculty_room_allocations fra
                JOIN semesters s ON fra.semester_id = s.semester_id
                JOIN rooms r ON fra.room_id = r.room_id";
            return DatabaseHelper.Instance.GetData(query);
        }

        private DataTable GetFacultyAdminRoles()
        {
            string query = @"
                SELECT f.name AS Faculty, far.role_name AS Role, s.term AS Term, s.year AS Year
                FROM faculty_admin_roles far
                JOIN faculty f ON far.faculty_id = f.faculty_id
                JOIN semesters s ON far.semester_id = s.semester_id";
            return DatabaseHelper.Instance.GetData(query);
        }

        private DataTable GetCoursesOfferedBySemester()
        {
            string query = @"
                SELECT s.term AS Term, s.year AS Year, c.course_name AS Course
                FROM faculty_courses fc
                JOIN semesters s ON fc.semester_id = s.semester_id
                JOIN courses c ON fc.course_id = c.course_id";
            return DatabaseHelper.Instance.GetData(query);
        }


        private void ExportToExcel(DataTable dt, string filePath)
        {
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Report");
                worksheet.Cells["A1"].LoadFromDataTable(dt, true);
                package.SaveAs(new FileInfo(filePath));
            }
        }

        private void generateButton_Click_1(object sender, EventArgs e)
        {
            string selectedReport = reportTypeComboBox.SelectedItem.ToString();

            switch (selectedReport)
            {
                case "Faculty with Assigned Courses":
                    dataGridViewReport.DataSource = GetFacultyCourseAssignments();
                    break;
                case "Rooms Allocated by Semester":
                    dataGridViewReport.DataSource = GetRoomsAllocatedBySemester();
                    break;
                case "Faculty Admin Roles":
                    dataGridViewReport.DataSource = GetFacultyAdminRoles();
                    break;
                case "Courses Offered in Each Semester":
                    dataGridViewReport.DataSource = GetCoursesOfferedBySemester();
                    break;
                default:
                    MessageBox.Show("Please select a valid report type.");
                    break;
            }

        }

        private void exportButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewReport.DataSource == null)
            {
                MessageBox.Show("No report data to export.");
                return;
            }

            DataTable dt = (DataTable)dataGridViewReport.DataSource;
            string filePath = "Report.xlsx";
            ExportToExcel(dt, filePath);
            MessageBox.Show("Report exported to Excel successfully!");


        }

        private void backLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DepartmentHeadDashborad loginForm = new DepartmentHeadDashborad();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}