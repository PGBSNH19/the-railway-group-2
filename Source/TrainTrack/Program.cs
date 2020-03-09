using System;
using TrainTrack.Classes;

namespace TrainTrack
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"/Users/william/OneDrive/Documents/GIT_local/the-railway-group-2/Data/trains.txt";
            var trainList = new Train();
            foreach (var t in trainList.ReadFile(path))
            {
                Console.WriteLine(t.ID + " " + t.Name + " " + t.MaxSpeed + " " + t.Operated);
            }
        }
    }
}
