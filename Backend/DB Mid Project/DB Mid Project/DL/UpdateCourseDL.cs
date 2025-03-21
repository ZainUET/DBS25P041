using System;
using System.Collections.Generic;
using System.Data;

namespace DB_Mid_Project.DL
{
    public class UpdateCourseDL
    {
        public static List<KeyValuePair<int, string>> GetCourses()
        {
            List<KeyValuePair<int, string>> courseList = new List<KeyValuePair<int, string>>();

            try
            {
                string query = "SELECT course_id, course_name FROM courses";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    while (reader.Read())
                    {
                        courseList.Add(new KeyValuePair<int, string>(
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

            return courseList;
        }

        public static DataRow GetCourseDetails(int courseId)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = $"SELECT course_name, course_type, credit_hours, contact_hours FROM courses WHERE course_id = {courseId}";
                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading course details: " + ex.Message);
            }

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public static int UpdateCourse(int courseId, string courseName, string courseType, int creditHours, int contactHours)
        {
            try
            {
                string query = $"UPDATE courses SET course_name = '{courseName}', course_type = '{courseType}', " +
                               $"credit_hours = {creditHours}, contact_hours = {contactHours} " +
                               $"WHERE course_id = {courseId}";

                return DatabaseHelper.Instance.Update(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating course: " + ex.Message);
            }
        }
    }
}
