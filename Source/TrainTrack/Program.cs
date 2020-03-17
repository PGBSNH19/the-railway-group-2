using System;
using TrainTrack.Classes;
using System.Threading;

namespace TrainTrack
{
    class Program
    {
        static void Main(string[] args)
        {




            //var pathTrain = @"Data/trains.txt";
            //Train train = new Train();
            //foreach (var _train in train.ReadFile(pathTrain))
            //{

            //}

            //var flyingScottsMan = train.Trains[0];


            //var pathTime = @"Data/timetable.txt";
            //TimeTable times = new TimeTable();
            //foreach (var _time in times.ReadFile(pathTime))
            //{

            //}

            //TimeTable time = times.TimeTables[1];


            //Console.WriteLine(time.DepartureTime);

            var trains = new Train().ReadFile();
            //var times = new TimeTable().ReadFile();


            var stations = new Station().ReadFile();

            var goldenArrow = trains[1];
            var lapplandståget = trains[2];

            //var x = new Controller();
            //var timez = x.FollowTimeTable(times, goldenArrow);



            var _ = new Controller().CheckForTrain(trains, goldenArrow.ID).FollowTimeTable(goldenArrow).StopAtStations(stations, goldenArrow).Start1(goldenArrow);
            var _2 = new Controller().CheckForTrain(trains, lapplandståget.ID).FollowTimeTable(lapplandståget).StopAtStations(stations, lapplandståget).Start2(lapplandståget);



        }
    }
}
