using System;
using TrainTrack.Classes;

namespace TrainTrack
{
    class Program
    {
        static void Main(string[] args)
        {
            //var path = @"/Users/william/OneDrive/Documents/GIT_local/the-railway-group-2/Data/trains.txt";
            //var trainList = new Train();
            //foreach (var t in trainList.ReadFile(path))
            //{
            //    Console.WriteLine(t.ID + " " + t.Name + " " + t.MaxSpeed + " " + t.Operated);
            //}

            //var pathPassangers = @"/Users/william/OneDrive/Documents/GIT_local/the-railway-group-2/Data/passengers.txt";
            //var passengers = new Passenger();
            //foreach (var passenger in passengers.ReadFile(pathPassangers))
            //{
            //    Console.WriteLine(passenger.Name);
            //}


            //var pathTimeTables = @"/Users/william/OneDrive/Documents/GIT_local/the-railway-group-2/Data/timetable.txt";
            //var timeTables = new TimeTable();
            //foreach (var timeTable in timeTables.ReadFile(pathTimeTables))
            //{
            //    Console.WriteLine(timeTable.DepartureTime + ", " + timeTable.ArrivalTime);
            //}

            var pathStations = @"/Users/william/OneDrive/Documents/GIT_local/the-railway-group-2/Data/stations.txt";
            var stations = new Station();
            foreach (var station in stations.ReadFile(pathStations))
            {
                Console.WriteLine(station.ID + ", " + station.EndStation);
            }

        }
    }
}
