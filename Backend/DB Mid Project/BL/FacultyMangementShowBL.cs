using System;
using System.Data;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.BL
{
    internal class FacultyMangementShowBL
    {
        private readonly FacultyManagementShowDL facultyDL;

        public FacultyMangementShowBL(string connectionString)
        {
            facultyDL = new FacultyManagementShowDL(connectionString);
        }

        public DataTable GetAllFaculty()
        {
            try
            {
                DataTable dt = facultyDL.GetAllFaculty();

                // Debugging: Check if data is fetched
                if (dt.Rows.Count > 0)
                {
                    Console.WriteLine("Data fetched successfully.");
                }
                else
                {
                    Console.WriteLine("No data found.");
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in business logic: " + ex.Message);
            }
        }
    }
}