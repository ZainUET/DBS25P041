using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    public class RemoveCourseDL
    {
        public static List<KeyValuePair<int, string>> GetCourses()
        {
            List<KeyValuePair<int, string>> courses = new List<KeyValuePair<int, string>>();

            try
            {
                string query = "SELECT course_id, course_name FROM courses";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    while (reader.Read())
                    {
                        courses.Add(new KeyValuePair<int, string>(
                            reader.GetInt32("course_id"),
                            reader.GetString("course_name")
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading courses: " + ex.Message);
            }

            return courses;
        }

        public static int RemoveCourse(int courseId)
        {
            try
            {
                string query = $"DELETE FROM courses WHERE course_id = {courseId}";
                return DatabaseHelper.Instance.Update(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Error removing course: " + ex.Message);
            }
        }
    }
}
