using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using DB_Mid_Project.DL;
using DB_Mid_Project.BL;

namespace DB_Mid_Project.DL
{
    public class ViewFacultyCourseSchedulesDL
    {
        public static List<ViewFacultyCourseSchedulesBL> GetFacultyCourseSchedules()
        {
            List<ViewFacultyCourseSchedulesBL> scheduleList = new List<ViewFacultyCourseSchedulesBL>();
            string query = @"
                SELECT fcs.schedule_id, f.name AS Faculty, c.course_name AS Course, 
                       r.room_name AS Room, fcs.day_of_week AS Day, 
                       fcs.start_time AS StartTime, fcs.end_time AS EndTime
                FROM faculty_course_schedule fcs
                JOIN faculty_courses fc ON fcs.faculty_course_id = fc.faculty_course_id
                JOIN faculty f ON fc.faculty_id = f.faculty_id
                JOIN courses c ON fc.course_id = c.course_id
                JOIN rooms r ON fcs.room_id = r.room_id";

            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                while (reader.Read())
                {
                    scheduleList.Add(new ViewFacultyCourseSchedulesBL(
                        reader.GetInt32("schedule_id"),
                        reader.GetString("Faculty"),
                        reader.GetString("Course"),
                        reader.GetString("Room"),
                        reader.GetString("Day"),
                        reader.GetTimeSpan("StartTime"),
                        reader.GetTimeSpan("EndTime")
                    ));
                }
            }
            return scheduleList;
        }
    }
}
