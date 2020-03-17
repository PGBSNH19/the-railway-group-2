using System;
namespace TrainTrack.Classes
{
    enum Status
    {
        Open,
        Closed
    }

    public class Crossing
    {
        public int ID { get; set; }
        public Enum Status { get; set; }
        public int Placement { get; set; }
    }
}