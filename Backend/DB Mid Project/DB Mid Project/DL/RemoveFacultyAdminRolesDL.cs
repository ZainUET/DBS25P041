using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DB_Mid_Project.BL;
using DB_Mid_Project.UI;

namespace DB_Mid_Project.DL
{
    public class RemoveFacultyAdminRolesDL
    {
        public static List<RemoveFacultyAdminRolesBL> GetFacultyAdminRoles()
        {
            List<RemoveFacultyAdminRolesBL> facultyAdminRoles = new List<RemoveFacultyAdminRolesBL>();
            string query = @"
                SELECT far.admin_role_id, f.name AS Faculty, far.role_name AS Role, s.term AS Term, s.year AS Year
                FROM faculty_admin_roles far
                JOIN faculty f ON far.faculty_id = f.faculty_id
                JOIN semesters s ON far.semester_id = s.semester_id";

            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                while (reader.Read())
                {
                    facultyAdminRoles.Add(new RemoveFacultyAdminRolesBL(
                        reader.GetInt32("admin_role_id"),
                        reader.GetString("Faculty"),
                        reader.GetString("Role"),
                        reader.GetString("Term"),
                        reader.GetInt32("Year")
                    ));
                }
            }
            return facultyAdminRoles;
        }

        public static bool RemoveFacultyAdminRole(int adminRoleId)
        {
            string query = $"DELETE FROM faculty_admin_roles WHERE admin_role_id = {adminRoleId}";
            return DatabaseHelper.Instance.Update(query) > 0;
        }
    }
}
