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

            Console.WriteLine(flyingScottsMan.Name);
            

        }
    }
}
