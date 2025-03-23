using System.Collections.Generic;
using DB_Mid_Project.DL;

namespace DB_Mid_Project.BL
{
    public static class AssignAdminRoleToFacultyBL
    {
        public static List<KeyValuePair<int, string>> GetFacultyList()
        {
            return AssignAdminRoleToFacultyDL.GetFacultyList();
        }

        public static List<string> GetRoles()
        {
            return AssignAdminRoleToFacultyDL.GetRoles();
        }

        public static List<KeyValuePair<int, string>> GetSemesters()
        {
            return AssignAdminRoleToFacultyDL.GetSemesters();
        }

        public static bool AssignAdminRole(int facultyId, string roleName, int semesterId)
        {
            return AssignAdminRoleToFacultyDL.AssignAdminRole(facultyId, roleName, semesterId);
        }
    }
}
