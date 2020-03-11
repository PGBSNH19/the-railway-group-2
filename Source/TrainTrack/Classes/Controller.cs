using System;
using System.Threading;
namespace TrainTrack.Classes
{
    public class Controller : IController
    {
        public int TrainID { get; set; }
        public int StationID { get; set; }
        public int TrainPosition { get; set; } //Crossing ; Open or close?

        public TimeSpan Departure { get; set; }
        public TimeSpan Arrival { get; set; }

        TimeSpan addMin = TimeSpan.FromMinutes(01);


        public IController StartTrain(TimeTable time, Train train)
        {
            Departure = TimeSpan.Parse(time.DepartureTime);

            var dpTime = TimeSpan.Parse(time.DepartureTime);
            var avTime = TimeSpan.Parse(time.ArrivalTime);
            for(int i = 0; i < Departure.Minutes; i++)
            {

                if ( avTime >= dpTime)
                {

                    Console.WriteLine("choo choo");
                }
                else
                {
                    Console.WriteLine($"Train stopped at {avTime} o clock");
                    break;

                }

                dpTime -= addMin;
                Thread.Sleep(1000);
            }


            return this;
        }

        public IController StopTrain(Train train)
        {
            throw new NotImplementedException();
        }
    }
}
