using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unicom_management_system_2025.Model
{
    internal class Timetable
    {
        public int TimetableID { get; set; }
        public int SubjectID { get; set; }
        public string TimeSlot { get; set; } // e.g., "Monday 10 AM"
        public int RoomID { get; set; }
    }
}
