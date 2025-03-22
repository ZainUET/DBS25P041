using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    public static class AssignProjectToFacultyDL
    {
        public static List<KeyValuePair<int, string>> GetFaculty()
        {
            List<KeyValuePair<int, string>> facultyList = new List<KeyValuePair<int, string>>();
            string query = "SELECT faculty_id, name FROM faculty";

            try
            {
                using (var connection = DatabaseHelper.Instance.getConnection())
                {
                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
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
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching faculty: " + ex.Message);
            }

            return facultyList;
        }

        public static List<KeyValuePair<int, string>> GetProjects()
        {
            List<KeyValuePair<int, string>> projectList = new List<KeyValuePair<int, string>>();
            string query = "SELECT project_id, title FROM projects";

            try
            {
                using (var connection = DatabaseHelper.Instance.getConnection())
                {
                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                projectList.Add(new KeyValuePair<int, string>(
                                    reader.GetInt32("project_id"),
                                    reader.GetString("title")
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching projects: " + ex.Message);
            }

            return projectList;
        }

        public static List<KeyValuePair<int, string>> GetSemesters()
        {
            List<KeyValuePair<int, string>> semesterList = new List<KeyValuePair<int, string>>();
            string query = "SELECT semester_id, CONCAT(term, ' ', year) AS semester FROM semesters";

            try
            {
                using (var connection = DatabaseHelper.Instance.getConnection())
                {
                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                semesterList.Add(new KeyValuePair<int, string>(
                                    reader.GetInt32("semester_id"),
                                    reader.GetString("semester")
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching semesters: " + ex.Message);
            }

            return semesterList;
        }

        public static bool AssignProject(int facultyId, int projectId, int semesterId, int supervisionHours)
        {
            string query = "INSERT INTO faculty_projects (faculty_id, project_id, semester_id, supervision_hours) VALUES (@facultyId, @projectId, @semesterId, @supervisionHours)";

            try
            {
                using (var connection = DatabaseHelper.Instance.getConnection())
                {
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@facultyId", facultyId);
                        command.Parameters.AddWithValue("@projectId", projectId);
                        command.Parameters.AddWithValue("@semesterId", semesterId);
                        command.Parameters.AddWithValue("@supervisionHours", supervisionHours);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error assigning project: " + ex.Message);
                return false;
            }
        }
    }
}
