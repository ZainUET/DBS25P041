using System;

namespace DB_Mid_Project.BL
{
    public class ViewFacultyCourseSchedulesBL
    {
        public int ScheduleId { get; set; }
        public string Faculty { get; set; }
        public string Course { get; set; }
        public string Room { get; set; }
        public string Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public ViewFacultyCourseSchedulesBL(int scheduleId, string faculty, string course, string room, string day, TimeSpan startTime, TimeSpan endTime)
        {
            ScheduleId = scheduleId;
            Faculty = faculty;
            Course = course;
            Room = room;
            Day = day;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
