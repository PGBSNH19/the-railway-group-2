using System;
namespace TrainTrack.Classes
{
    public class TrainTrack
    {
        public int ID { get; set; }
        public int StationPlacement { get; set; }
        public int SwitchID { get; set; }
        public int CrossingID { get; set; }
        public int Distance { get; set; }
        public int StationID { get; set; }

        public TrainTrack(int ID,int StationPlacement,int SwitchID,int CrossingID,int Distance, int StationID)
        {
            this.ID = ID;
            this.StationPlacement = StationPlacement;
            this.SwitchID = SwitchID;
            this.CrossingID = CrossingID;
            this.Distance = Distance;
            this.StationID = StationID;
        }
    }
}
