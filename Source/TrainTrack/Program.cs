using System.Collections.Generic;
using TrainTrack.Classes;

namespace TrainTrack
{
    class Program
    {
        static void Main(string[] args)
        {

            var trains = new Train().ReadFile();
            var flyingScotsman = trains.Find(x => x.Name == "Flying Scotsman");
            var goldenArrow = trains.Find(x => x.Name == "Golden Arrow");
            var lapplandståget = trains.Find(x => x.Name == "Lapplandståget");
            var norrlandståget = trains.Find(x => x.Name == "Norrlandståget");



            List<Passenger> passengers = new Passenger().ReadFile();



            var controller = new Controller()
                .CheckForTrain(trains, goldenArrow.ID)
                .FollowTimeTable(goldenArrow)
                .LoadTrainWithPassengers(passengers)
                .SetCrossing(Status.Open)
                .StartThread(goldenArrow);
        }
    }
}
