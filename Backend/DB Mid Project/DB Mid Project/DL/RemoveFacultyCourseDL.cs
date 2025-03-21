using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    public class RemoveFacultyCourseDL
    {
        public static DataTable GetFacultyCourses()
        {
            try
            {
                string query = @"
                    SELECT fc.faculty_course_id, f.name AS Faculty, c.course_name AS Course, s.term AS Term, s.year AS Year
                    FROM faculty_courses fc
                    JOIN faculty f ON fc.faculty_id = f.faculty_id
                    JOIN courses c ON fc.course_id = c.course_id
                    JOIN semesters s ON fc.semester_id = s.semester_id";

                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading faculty-course assignments: " + ex.Message);
            }
        }

        public static int RemoveFacultyCourse(int facultyCourseId)
        {
            try
            {
                string query = $"DELETE FROM faculty_courses WHERE faculty_course_id = {facultyCourseId}";
                return DatabaseHelper.Instance.Update(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Error removing faculty-course assignment: " + ex.Message);
            }
        }
    }
}
