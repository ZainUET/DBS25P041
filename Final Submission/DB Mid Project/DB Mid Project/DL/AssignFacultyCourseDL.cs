using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    public class FacultyCourseDL
    {
        public static List<KeyValuePair<int, string>> GetFacultyList()
        {
            List<KeyValuePair<int, string>> facultyList = new List<KeyValuePair<int, string>>();
            try
            {
                string query = "SELECT faculty_id, name FROM faculty";
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
                throw new Exception("Error loading faculty: " + ex.Message);
            }
            return facultyList;
        }

        public static List<KeyValuePair<int, string>> GetCourseList()
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

        public static List<KeyValuePair<int, string>> GetSemesterList()
        {
            List<KeyValuePair<int, string>> semesterList = new List<KeyValuePair<int, string>>();
            try
            {
                string query = "SELECT semester_id, CONCAT(term, ' ', year) AS semester FROM semesters";
                using (var reader = DatabaseHelper.Instance.getData(query))
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
            catch (Exception ex)
            {
                throw new Exception("Error loading semesters: " + ex.Message);
            }
            return semesterList;
        }

        public static int AssignCourseToFaculty(int facultyId, int courseId, int semesterId)
        {
            try
            {
                string query = $"INSERT INTO faculty_courses (faculty_id, course_id, semester_id) VALUES ({facultyId}, {courseId}, {semesterId})";
                return DatabaseHelper.Instance.Update(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Error assigning course to faculty: " + ex.Message);
            }
        }
    }
}
