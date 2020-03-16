using System;
using System.Collections.Generic;

namespace TrainTrack.Classes
{
    public interface IController
    {

        IController CheckForTrain(List<Train> trains, int check);


        IController FollowTimeTable(Train train);

        IController StartTrain(Train train);

        IController Start1(Train train);


    }
}
