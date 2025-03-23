using System;
using System.Data;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.BL
{
    internal class FacultyManagementAddBL
    {
        private readonly FacultyManagementAddDL facultyDL;

        public FacultyManagementAddBL()
        {
            facultyDL = new FacultyManagementAddDL();
        }

        public DataTable GetDesignations()
        {
            return facultyDL.GetDesignations();
        }

        public void AddFaculty(string name, string email, string contact, int designationId, string researchArea, int teachingHours)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(contact) || designationId == -1)
            {
                throw new Exception("Please fill all required fields correctly.");
            }

            facultyDL.AddFaculty(name, email, contact, designationId, researchArea, teachingHours);
        }
    }
}
