using System.Collections.Generic;
using TrainTrack.Classes;
using Xunit;

namespace TrainTrack.Tests
{
    public class LoadDataFromFile
    {
        [Fact]
        public void Test1()
        {
            Train train = new Train();
            List<Train> trainsList = train.Trains;
        }
    }
}
