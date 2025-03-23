using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DB_Mid_Project.BL;

namespace DB_Mid_Project.DL
{
    public class ScheduleCourseForFacultyDL
    {
        public static List<ScheduleCourseForFacultyBL> GetFaculty()
        {
            List<ScheduleCourseForFacultyBL> facultyList = new List<ScheduleCourseForFacultyBL>();
            string query = "SELECT faculty_id, name FROM faculty";

            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                while (reader.Read())
                {
                    facultyList.Add(new ScheduleCourseForFacultyBL(
                        reader.GetInt32("faculty_id"),
                        reader.GetString("name")
                    ));
                }
            }
            return facultyList;
        }

        public static List<ScheduleCourseForFacultyBL> GetCourses()
        {
            List<ScheduleCourseForFacultyBL> courseList = new List<ScheduleCourseForFacultyBL>();
            string query = "SELECT course_id, course_name FROM courses";

            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                while (reader.Read())
                {
                    courseList.Add(new ScheduleCourseForFacultyBL(
                        reader.GetInt32("course_id"),
                        reader.GetString("course_name")
                    ));
                }
            }
            return courseList;
        }

        public static List<ScheduleCourseForFacultyBL> GetRooms()
        {
            List<ScheduleCourseForFacultyBL> roomList = new List<ScheduleCourseForFacultyBL>();
            string query = "SELECT room_id, room_name FROM rooms";

            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                while (reader.Read())
                {
                    roomList.Add(new ScheduleCourseForFacultyBL(
                        reader.GetInt32("room_id"),
                        reader.GetString("room_name")
                    ));
                }
            }
            return roomList;
        }

        public static bool ScheduleCourse(int facultyId, int courseId, int roomId, string dayOfWeek, TimeSpan startTime, TimeSpan endTime)
        {
            string query = $"INSERT INTO faculty_course_schedule (faculty_course_id, room_id, day_of_week, start_time, end_time) " +
                           $"VALUES ((SELECT faculty_course_id FROM faculty_courses WHERE faculty_id = {facultyId} AND course_id = {courseId}), {roomId}, '{dayOfWeek}', '{startTime}', '{endTime}')";

            return DatabaseHelper.Instance.Update(query) > 0;
        }
    }
}
