using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    public class Faculty
    {
        public int FacultyId { get; set; }
        public string Name { get; set; }
    }

    public class Room
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }
    }

    public class Semester
    {
        public int SemesterId { get; set; }
        public string Term { get; set; }
        public int Year { get; set; }
        public string SemesterName => $"{Term} {Year}";
    }

    public static class AllocateRoomToFacultyDL
    {
        public static List<Faculty> GetFaculty()
        {
            List<Faculty> facultyList = new List<Faculty>();
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
                                facultyList.Add(new Faculty
                                {
                                    FacultyId = reader.GetInt32("faculty_id"),
                                    Name = reader.GetString("name")
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading faculty: " + ex.Message);
            }

            return facultyList;
        }

        public static List<Room> GetRooms()
        {
            List<Room> roomList = new List<Room>();
            string query = "SELECT room_id, room_name FROM rooms";

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
                                roomList.Add(new Room
                                {
                                    RoomId = reader.GetInt32("room_id"),
                                    RoomName = reader.GetString("room_name")
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading rooms: " + ex.Message);
            }

            return roomList;
        }

        public static List<Semester> GetSemesters()
        {
            List<Semester> semesterList = new List<Semester>();
            string query = "SELECT semester_id, term, year FROM semesters";

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
                                semesterList.Add(new Semester
                                {
                                    SemesterId = reader.GetInt32("semester_id"),
                                    Term = reader.GetString("term"),
                                    Year = reader.GetInt32("year")
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading semesters: " + ex.Message);
            }

            return semesterList;
        }

        public static bool AllocateRoom(int facultyId, int roomId, int semesterId, int reservedHours)
        {
            string query = "INSERT INTO faculty_room_allocations (faculty_id, room_id, semester_id, reserved_hours) VALUES (@facultyId, @roomId, @semesterId, @reservedHours)";

            try
            {
                using (var connection = DatabaseHelper.Instance.getConnection())
                {
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@facultyId", facultyId);
                        command.Parameters.AddWithValue("@roomId", roomId);
                        command.Parameters.AddWithValue("@semesterId", semesterId);
                        command.Parameters.AddWithValue("@reservedHours", reservedHours);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error allocating room: " + ex.Message);
                return false;
            }
        }
    }
}
