using System.Collections.Generic;
using TrainTrack.Classes;
using TrainTrack.Logging;

namespace TrainTrack
{
    class Program
    {
        static void Main(string[] args)
        {
            var passengers = new Passenger().ReadFile();
            var stations = new Station().ReadFile();
            var trains = new Train().ReadFile();

            var goldenArrow = trains.Find(x => x.Name == "Golden Arrow");
            var lapplandståget = trains.Find(x => x.Name == "Lapplandståget");

            var trainRoute1 = new Controller()
                .FollowTimeTable(goldenArrow)
                .StopAtStations(stations, goldenArrow)
                .LoadTrainWithPassengers(passengers)
                .SetCrossing(Status.Open)
                .StartThread1(goldenArrow);
            LogHelper.Log(LogTarget.File, trainRoute1);


            var trainRoute2 = new Controller()
                .FollowTimeTable(lapplandståget)
                .StopAtStations(stations, lapplandståget)
                .LoadTrainWithPassengers(passengers)
                .SetCrossing(Status.Open)
                .StartThread2(lapplandståget);
        }
    }
}
