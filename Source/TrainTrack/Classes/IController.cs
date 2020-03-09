using System;
namespace TrainTrack.Classes
{
    public interface IController
    {
        IController StartTrain(Train train);
        IController StopTrain(Train train);
    }
}
