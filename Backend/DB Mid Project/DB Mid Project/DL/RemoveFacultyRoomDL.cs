using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace DB_Mid_Project.DL
{
    public class AllocateRoomTOFaculty
    {
        public int AllocationId { get; set; }
        public string FacultyName { get; set; }
        public string RoomName { get; set; }
        public string Term { get; set; }
        public int Year { get; set; }
        public int ReservedHours { get; set; }
    }

    public static class RemoveFacultyRoomDL
    {
        public static List<FacultyRoomAllocation> GetFacultyRoomAllocations()
        {
            List<FacultyRoomAllocation> allocations = new List<FacultyRoomAllocation>();
            string query = @"
                SELECT fra.allocation_id, f.name AS Faculty, r.room_name AS Room, 
                       s.term AS Term, s.year AS Year, fra.reserved_hours AS ReservedHours
                FROM faculty_room_allocations fra
                JOIN faculty f ON fra.faculty_id = f.faculty_id
                JOIN rooms r ON fra.room_id = r.room_id
                JOIN semesters s ON fra.semester_id = s.semester_id";

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
                                allocations.Add(new FacultyRoomAllocation
                                {
                                    AllocationId = reader.GetInt32("allocation_id"),
                                    FacultyName = reader.GetString("Faculty"),
                                    RoomName = reader.GetString("Room"),
                                    Term = reader.GetString("Term"),
                                    Year = reader.GetInt32("Year"),
                                    ReservedHours = reader.GetInt32("ReservedHours")
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching faculty-room allocations: " + ex.Message);
            }

            return allocations;
        }

        public static bool RemoveFacultyRoomAllocation(int allocationId)
        {
            string query = $"DELETE FROM faculty_room_allocations WHERE allocation_id = {allocationId}";
            try
            {
                return DatabaseHelper.Instance.Update(query) > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting faculty-room allocation: " + ex.Message);
                return false;
            }
        }
    }
}
