using System;
using System.Collections.Generic;

namespace TrainTrack.Classes
{
    public interface IController
    {
        IController CheckForTrain(List<Train> trains, int check);
        IController FollowTimeTable(Train train);
        IController StartTrain(Train train);
        IController StartThread1(Train train);
        IController StartThread2(Train train);
        IController StopAtStations(List<Station> stations, Train train);
        IController LoadTrainWithPassengers(List<Passenger> passengers);
        IController SetCrossing(Enum Status);

    }
}
