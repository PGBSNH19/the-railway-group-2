using System;
namespace TrainTrack.Classes
{
    public interface IController
    {
        IController StartTrain(TimeTable time, Train train);
        IController StopTrain(Train train);

        
    }
}
