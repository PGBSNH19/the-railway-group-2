using System;
using System.Collections.Generic;
using System.IO;

namespace TrainTrack.Classes
{
    public class TimeTable : IGenericList<TimeTable>
    {
        public int TrainID { get; set; }
        public int StationID { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public string FilePath { get; set; } = "Data/timetable.txt";

        public List<TimeTable> TimeTables { get; set; } = new List<TimeTable>();

        public static TimeTable CreateFromLine(string line)
        {
            string[] split = line.Split(';', ',');
            TimeTable timeTable = new TimeTable
            {
                TrainID = int.Parse(split[0]),
                StationID = int.Parse(split[1]),
                DepartureTime = (split[2] == "null" ? "00:00" : split[2]),
                ArrivalTime = (split[3] == "null" ? "00:00" : split[3])

            };

            return timeTable;
        }

        public List<TimeTable> ReadFile()
        {
            var lines = File.ReadAllLines(FilePath);

            for (int i = 1; i < lines.Length; i++)
            {
                TimeTable timeTable = CreateFromLine(lines[i]);
                TimeTables.Add(timeTable);
            }

            return TimeTables;
        }
    }
}
