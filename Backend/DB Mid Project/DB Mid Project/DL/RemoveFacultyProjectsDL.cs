using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    public class ShowFacultyProject
    {
        public int FacultyProjectId { get; set; }
        public string FacultyName { get; set; }
        public string ProjectTitle { get; set; }
        public string Term { get; set; }
        public int Year { get; set; }
        public int SupervisionHours { get; set; }
    }

    public static class RemoveFacultyProjectsDL
    {
        public static List<FacultyProject> GetFacultyProjects()
        {
            List<FacultyProject> facultyProjects = new List<FacultyProject>();

            string query = @"
                SELECT fp.faculty_project_id, f.name AS Faculty, p.title AS Project, 
                       s.term AS Term, s.year AS Year, fp.supervision_hours AS SupervisionHours
                FROM faculty_projects fp
                JOIN faculty f ON fp.faculty_id = f.faculty_id
                JOIN projects p ON fp.project_id = p.project_id
                JOIN semesters s ON fp.semester_id = s.semester_id";

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
                                facultyProjects.Add(new FacultyProject
                                {
                                    FacultyProjectId = reader.GetInt32("faculty_project_id"),
                                    FacultyName = reader.GetString("Faculty"),
                                    ProjectTitle = reader.GetString("Project"),
                                    Term = reader.GetString("Term"),
                                    Year = reader.GetInt32("Year"),
                                    SupervisionHours = reader.GetInt32("SupervisionHours")
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching faculty-project assignments: " + ex.Message);
            }

            return facultyProjects;
        }

        public static bool RemoveFacultyProject(int facultyProjectId)
        {
            string query = "DELETE FROM faculty_projects WHERE faculty_project_id = @facultyProjectId";

            try
            {
                using (var connection = DatabaseHelper.Instance.getConnection())
                {
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@facultyProjectId", facultyProjectId);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error removing faculty-project assignment: " + ex.Message);
                return false;
            }
        }
    }
}
