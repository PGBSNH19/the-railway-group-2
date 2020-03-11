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
        public Station StationID { get; set; }

        public TrainTrack(int ID,int StationPlacement,Enum SwitchPlacement,Enum Crossing,int Distance, Station StationID)
        {
            this.ID = ID;
            this.StationPlacement = StationPlacement;
            this.SwitchPlacement = SwitchPlacement;
            this.Crossing = Crossing;
            this.Distance = Distance;
            this.StationID = StationID;
        }
    }
}
