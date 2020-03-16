using System;
using TrainTrack.Classes;

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
            var times = new TimeTable().ReadFile();

            var goldenArrow = trains[1];


            var controller = new Controller().StartTrain(times, goldenArrow).CheckForTrain(trains, goldenArrow.ID).FollowTimeTable(times, goldenArrow);



        }
    }
}
