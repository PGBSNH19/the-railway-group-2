using System;
using System.Collections.Generic;

namespace TrainTrack.Classes
{
    public interface IController
    {
        IController StartTrain(List<TimeTable> times, Train train);

        Train CheckForTrain(List<Train> trains, int check);


        List<TimeTable> FollowTimeTable(List<TimeTable> times, Train train);



    }
}
