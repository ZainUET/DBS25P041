using System;
using System.Data;

namespace DB_Mid_Project.DL
{
    public class ViewAssignedFacultyCoursesDL
    {
        public static DataTable GetFacultyCourses()
        {
            DataTable dt = new DataTable();
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
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading faculty-course assignments: " + ex.Message);
            }

            return dt;
        }
    }
}
