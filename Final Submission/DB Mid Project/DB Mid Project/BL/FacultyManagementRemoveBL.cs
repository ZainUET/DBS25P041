using System;
using System.Data;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.BL
{
    internal class FacultyManagementRemoveBL
    {
        private readonly FacultyManagementRemoveDL facultyDL;

        public FacultyManagementRemoveBL()
        {
            facultyDL = new FacultyManagementRemoveDL();
        }

        public DataTable GetFacultyList()
        {
            return facultyDL.GetFacultyList();
        }

        public void RemoveFaculty(int facultyId)
        {
            if (facultyId == -1)
            {
                throw new Exception("Please select a valid faculty member.");
            }

            facultyDL.DeleteFaculty(facultyId);
        }
    }
}
