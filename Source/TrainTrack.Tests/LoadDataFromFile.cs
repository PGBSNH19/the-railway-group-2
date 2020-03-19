using System.Collections.Generic;
using TrainTrack.Classes;
using Xunit;

namespace TrainTrack.Tests
{
    public class LoadDataFromFile
    {
        [Fact]
        public void ReadTrainDataAndParseTest()
        {
            List<Train> trains = new Train().ReadFile();

            Assert.Equal(1, trains[0].ID);
            Assert.Equal("Flying Scotsman", trains[0].Name);
            Assert.Equal(100, trains[0].MaxSpeed);
            Assert.False(trains[0].Operated);
        }

        [Fact]
        public void ReadTrainTrackDataAndParseTest()
        {
            List<TimeTable> timeTables = new TimeTable().ReadFile();

            Assert.Equal(2, timeTables[0].TrainID);
            Assert.Equal(1, timeTables[0].StationID);
            Assert.Equal("10:20", timeTables[0].DepartureTime);
            Assert.Equal("00:00", timeTables[0].ArrivalTime);
        }

        [Fact]
        public void ReadPassengerDataAndParseTest()
        {
            List<Passenger> passengers = new Passenger().ReadFile();

            Assert.Equal(1, passengers[0].ID);
            Assert.Equal("Misty Walton", passengers[0].Name);
        }

        [Fact]
        public void ReadStationDataAndParseTest()
        {
            List<Station> stations = new Station().ReadFile();

            Assert.Equal(1, stations[0].ID);
            Assert.Equal("Stonecro", stations[0].Name);
            Assert.True(stations[0].EndStation);
        }
    }
}
