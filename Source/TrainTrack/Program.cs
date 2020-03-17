using TrainTrack.Classes;

namespace TrainTrack
{
    class Program
    {
        static void Main(string[] args)
        {
            var trains = new Train().ReadFile();
            var goldenArrow = trains[1];

            var controller = new Controller()
                .CheckForTrain(trains, goldenArrow.ID)
                .FollowTimeTable(goldenArrow)
                .StartThread(goldenArrow);
        }
    }
}
