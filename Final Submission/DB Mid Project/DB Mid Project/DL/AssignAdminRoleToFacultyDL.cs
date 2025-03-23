using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    public static class AssignAdminRoleToFacultyDL
    {
        public static List<KeyValuePair<int, string>> GetFacultyList()
        {
            List<KeyValuePair<int, string>> facultyList = new List<KeyValuePair<int, string>>();
            string query = "SELECT faculty_id, name FROM faculty";

            try
            {
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    while (reader.Read())
                    {
                        facultyList.Add(new KeyValuePair<int, string>(
                            reader.GetInt32("faculty_id"),
                            reader.GetString("name")
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading faculty: " + ex.Message);
            }

            return facultyList;
        }

        public static List<string> GetRoles()
        {
            List<string> roles = new List<string>();
            string query = "SELECT value FROM lookup WHERE category = 'UserRoles'";

            try
            {
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    while (reader.Read())
                    {
                        roles.Add(reader.GetString("value"));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading roles: " + ex.Message);
            }

            return roles;
        }

        public static List<KeyValuePair<int, string>> GetSemesters()
        {
            List<KeyValuePair<int, string>> semesters = new List<KeyValuePair<int, string>>();
            string query = "SELECT semester_id, CONCAT(term, ' ', year) AS semester FROM semesters";

            try
            {
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    while (reader.Read())
                    {
                        semesters.Add(new KeyValuePair<int, string>(
                            reader.GetInt32("semester_id"),
                            reader.GetString("semester")
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading semesters: " + ex.Message);
            }

            return semesters;
        }

        public static bool AssignAdminRole(int facultyId, string roleName, int semesterId)
        {
            string query = $"INSERT INTO faculty_admin_roles (faculty_id, role_name, semester_id) VALUES ({facultyId}, '{roleName}', {semesterId})";

            try
            {
                return DatabaseHelper.Instance.Update(query) > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error assigning admin role: " + ex.Message);
                return false;
            }
        }
    }
}
