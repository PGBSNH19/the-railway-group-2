using System;
using System.Collections.Generic;

namespace TrainTrack.Classes
{
    public interface IController
    {
        IController StartTrain(List<TimeTable> times, Train train);
        IController CheckForTrain(List<Train> trains, int check);
        IController FollowTimeTable(List<TimeTable> times, Train train);



    }
}
