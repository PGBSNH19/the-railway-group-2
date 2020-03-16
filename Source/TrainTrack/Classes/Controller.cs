using System;
using System.Collections.Generic;
using System.Linq;
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

        public TimeTable myTimeTable;

        
        //TimeSpan addMin = TimeSpan.FromMinutes(01);

        public IController StartTrain(List<TimeTable> times, Train train)
        {
            var train2TT = times;



            for (int i = 0; i < train2TT.Count - 1; i++)
                {
                    TimeSpan addOneMinute = TimeSpan.FromMinutes(1);
                    DateTime departureTime = DateTime.Parse(train2TT[i].DepartureTime);
                    DateTime arrivalTime = DateTime.Parse(train2TT[i + 1].ArrivalTime);

                    Console.WriteLine($"Departure Time: { departureTime.ToString("HH:mm") }");
                    Console.WriteLine($"Train: { train.Name }");
                    Console.WriteLine();

                    if (i == 1)
                    {
                        Console.WriteLine("Train is halting for 2 minutes...before continuing the journey!");
                        Console.WriteLine();
                        Console.WriteLine($"Departure Time: { departureTime.ToString("HH:mm") }");
                        Thread.Sleep(1000);
                    }

                    while (departureTime < arrivalTime)
                    {
                        Console.WriteLine($"choo choo { departureTime.ToString("HH:mm") }");
                        departureTime += addOneMinute;
                        arrivalTime.AddMinutes(addOneMinute.Minutes);
                        Thread.Sleep(200);
                    }
                    Console.WriteLine($"Arrival Time: { arrivalTime.ToString("HH:mm") }");
                    Console.WriteLine();
                }

            return this;
            

            //Departure = TimeSpan.Parse(time.DepartureTime);

            //var dpTime = TimeSpan.Parse(time.DepartureTime);
            //var avTime = TimeSpan.Parse(time.ArrivalTime);
            //for(int i = 0; i < Departure.Minutes; i++)
            //{

            //    if ( avTime <= dpTime)
            //    {

            //        Console.WriteLine($"chuu choo");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Train stopped at Saturday {avTime} o´clock and Departed at Friday {dpTime}!");
            //        break;

            //    }

            //    dpTime -= addMin;
            //    Thread.Sleep(1000);
            //}


           
        }


        public IController CheckForTrain(List<Train> trains, int check)
        {
            var train = trains.Where(t => t.ID == check).ToList().First();
            return this;
        }

        public IController FollowTimeTable(List<TimeTable> times, Train train)
        {
            var timeTable = times.Where(t => t.TrainID == train.ID).ToList();
            return this;
        }


    }
}
