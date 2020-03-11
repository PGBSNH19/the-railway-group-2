using System;
using TrainTrack.Classes;

namespace TrainTrack
{
    class Program
    {
        static void Main(string[] args)
        {
            var pathTrain = @"/Users/william/OneDrive/Documents/GIT_local/the-railway-group-2/Data/trains.txt";
            Train train = new Train();
            foreach (var _train in train.ReadFile(pathTrain))
            {

            }

            var flyingScottsMan = train.Trains[0];


            var pathTime = @"/Users/william/OneDrive/Documents/GIT_local/the-railway-group-2/Data/timetable.txt";
            TimeTable times = new TimeTable();
            foreach (var _time in times.ReadFile(pathTime))
            {

            }

            TimeTable time = times.TimeTables[1];


            Console.WriteLine(time.DepartureTime);

            _ = new Controller().StartTrain(time, flyingScottsMan);
            

        }
    }
}
