using System;
namespace TrainTrack.Classes
{
    enum Direction
    {
        Left,
        Right
    }

    public class Switch
    {
        public int ID { get; set; }
        public int Placement { get; set; }
        public Enum Direction { get; set; }
    }
}
