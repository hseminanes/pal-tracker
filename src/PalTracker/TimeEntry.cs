using System;

namespace PalTracker
{
    public struct TimeEntry
    {
        public int? Id { get; set; }
        public int ProjectId  { get; set; }
        public int UserId  { get; set; }
        public DateTime Date { get; set; }
        public int Hours  { get; set; }

        public TimeEntry(int id, int param2, int param3, DateTime date, int param4)
        {
            Id = id;
            ProjectId  = param2;
            UserId  = param3;
            Date = date;
            Hours  = param4;
        }

        public TimeEntry(int param2, int param3, DateTime date, int param4)
        {
            Id = Int32.MinValue;
            ProjectId  = param2;
            UserId  = param3;
            Date = date;
            Hours  = param4;
        }
    }
}