using System;
namespace TrainTrack.Classes
{
    public class TimeTable
    {
        public int TrainID { get; set; }
        public int StationID { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }

    }
}
