using System;
using System.Data;
using DB_Mid_Project.DL;
using DB_Mid_Project.UI;

namespace DB_Mid_Project.BL
{
    internal class FacultyManagementUpdateBL
    {
        private readonly FacultyManagementUpdateDL facultyDL;

        public FacultyManagementUpdateBL()
        {
            facultyDL = new FacultyManagementUpdateDL();
        }

        public DataTable GetFacultyList()
        {
            return facultyDL.GetFacultyList();
        }

        public DataTable GetDesignations()
        {
            return facultyDL.GetDesignations();
        }

        public void UpdateFaculty(int facultyId, string name, string email, string contact, int designationId, string researchArea, int teachingHours)
        {
            if (facultyId == -1)
            {
                throw new Exception("Please select a valid faculty member.");
            }
            if (designationId == -1)
            {
                throw new Exception("Please select a valid designation.");
            }
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(contact))
            {
                throw new Exception("Fields cannot be empty.");
            }
            if (!email.Contains("@"))
            {
                throw new Exception("Invalid email format.");
            }
            if (teachingHours < 0)
            {
                throw new Exception("Teaching hours must be positive.");
            }

            facultyDL.UpdateFaculty(facultyId, name, email, contact, designationId, researchArea, teachingHours);
        }
    }
}
