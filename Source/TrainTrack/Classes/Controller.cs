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
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }

        public List<TimeTable> myTimeTable;
        public Thread _thread1;
        public Thread _thread2;

        public List<Station> stopStationsT3;
        public List<Station> stopStationsT2;

        List<TimeTable> times = new TimeTable().ReadFile();

        public IController StartTrain(Train train)
        {
            var train2TT = myTimeTable;

            var stations = stopStationsT3;

            if (train.ID == 2)
            {
                stations = stopStationsT2;
            }

            var endStation = stations.Last();

            for (int i = 0; i < train2TT.Count - 1; i++)
            {
                TimeSpan addOneMinute = TimeSpan.FromMinutes(1);
                Departure = DateTime.Parse(train2TT[i].DepartureTime);
                Arrival = DateTime.Parse(train2TT[i + 1].ArrivalTime);

                for (int j = 0; j < stations.Count; j++)
                {

                    if (stations[j].ID == train2TT[i].StationID)
                    {

                        if (train2TT[i].ArrivalTime == "00:00")
                        {
                            Console.WriteLine("Train " + train.Name + " is leaving from " + stations[i].Name + " at " + train2TT[i].DepartureTime);
                            Console.WriteLine();
                        }

                        else if (train2TT[i].ArrivalTime != "00:00")
                        {
                            Console.WriteLine(train.Name);
                            Console.WriteLine("Arrived at " + stations[j].Name + "at " + train2TT[i].ArrivalTime);
                            Console.WriteLine("Next departure: " + train2TT[i].DepartureTime);
                            Console.WriteLine();
                        }

                        else if (stations[j].EndStation == true)
                        {
                            Console.WriteLine(stations[j].Name + " is the final destination for " + train.Name);
                            Console.WriteLine("Arrived at " + train2TT[i].ArrivalTime);
                            Console.WriteLine();
                        }

                        if (i == 1)
                        {
                            
                            Thread.Sleep(2000);
                        }

                        while (Departure < Arrival)
                        {
                            Console.WriteLine($"{train.Name} says: Choo choo { Departure.ToString("HH:mm") }");
                            Departure += addOneMinute;
                            Arrival.AddMinutes(addOneMinute.Minutes);
                            Thread.Sleep(200);
                        }

                    }

                }

                Console.WriteLine($"{train.Name} Arrival Time: { Arrival.ToString("HH:mm") }");
                Console.WriteLine();
            }

            Console.WriteLine("Arrived at " + endStation.Name + " which is");
            Console.WriteLine(train.Name + "'s final destination.");
            Console.WriteLine();
            
            return this;
        }

        public IController StartThread1(Train train)
        {
            _thread1 = new Thread(() => StartTrain(train));
            _thread1.Start();

            return this;
        }

        public IController StartThread2(Train train)
        {
            _thread2 = new Thread(() => StartTrain(train));
            _thread2.Start();

            return this;
        }

        public IController CheckForTrain(List<Train> trains, int check)
        {
            var train = trains.Where(t => t.ID == check).ToList().First();

            return this;
        }

        public IController FollowTimeTable(Train train)
        {
            myTimeTable = times.Where(t => t.TrainID == train.ID).ToList();

            return this;
        }

        public IController StopAtStations(List<Station> stations, Train train)
        {
            if (train.ID == 3)
            {
                stopStationsT3 = stations.Where(stations => myTimeTable.Any(t => t.StationID == stations.ID))
                                         .OrderByDescending(s => s.ID)
                                         .ToList();
            }
            else
            {
                stopStationsT2 = stations.Where(stations => myTimeTable.Any(t => t.StationID == stations.ID))
                                         .ToList();
            }
            return this;
        }

        public IController LoadTrainWithPassengers(List<Passenger> passengers)
        {
            var travelers = passengers.Where(x => x.ID <= 10);

            foreach (var traveler in travelers)
            {
                Console.WriteLine($"{traveler.Name} has stepped onboard");
                Thread.Sleep(500);
            }
            Console.WriteLine("\n\n");

            return this;
        }

        public IController SetCrossing(Enum Status)
        {
            var crossing = new Crossing()
            {
                ID = 1,
                Status = Status,
                Placement = 20
            };
            Console.WriteLine($"\nCrossing: {crossing.ID} is now set to {crossing.Status} and it lies {crossing.Placement}km ahead \n");
            
            return this;
        }
    }
}
