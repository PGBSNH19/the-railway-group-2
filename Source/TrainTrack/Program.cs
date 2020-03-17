using System.Collections.Generic;
using TrainTrack.Classes;

namespace TrainTrack
{
    class Program
    {
        static void Main(string[] args)
        {
            var trains = new Train().ReadFile();
            var goldenArrow = trains.Find(x => x.Name == "Golden Arrow");
            var lapplandståget = trains.Find(x => x.Name == "Lapplandståget");

            List<Passenger> passengers = new Passenger().ReadFile();
            var stations = new Station().ReadFile();

            var trainRoute1 = new Controller()
                .CheckForTrain(trains, goldenArrow.ID)
                .FollowTimeTable(goldenArrow)
                .StopAtStations(stations, goldenArrow)
                .LoadTrainWithPassengers(passengers)
                .SetCrossing(Status.Open)
                .StartThread1(goldenArrow);

            var trainRoute2 = new Controller()
                .CheckForTrain(trains, lapplandståget.ID)
                .FollowTimeTable(lapplandståget)
                .StopAtStations(stations, lapplandståget)
                .LoadTrainWithPassengers(passengers)
                .SetCrossing(Status.Open)
                .StartThread2(lapplandståget);
        }
    }
}
