using System;
using System.Collections.Generic;

namespace TrainTrack.Classes
{
    public interface IController
    {

        IController CheckForTrain(List<Train> trains, int check);


        IController FollowTimeTable(Train train);

        IController StopAtStations(List<Station> stations);

        IController StartTrain(Train train);

        IController Start1(Train train);

        IController Start2(Train train);


    }
}
