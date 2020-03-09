using System;
namespace TrainTrack.Classes
{
    public class TrainTrack
    {
        public int ID { get; set; }
        public int StationPlacement { get; set; }
        public Enum SwitchPlacement { get; set; }
        public Enum Crossing { get; set; }
        public int Distance { get; set; }
    }
}
