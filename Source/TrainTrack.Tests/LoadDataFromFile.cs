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
            List<Train> trains = new Train().ReadFile();

            Assert.Equal(1, trains[0].ID);
            Assert.Equal("Flying Scotsman", trains[0].Name);
            Assert.Equal(100, trains[0].MaxSpeed);
            Assert.False(trains[0].Operated);
        }
    }
}
