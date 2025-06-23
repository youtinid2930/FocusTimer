using System;

namespace FocusTimer.Models
{
    public class PomodoroSession
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public DateTime StartTime { get; set; }
        public int DurationMinutes { get; set; } = 25;
    }
}
