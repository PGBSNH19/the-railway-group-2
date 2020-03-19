using System;
using System.Collections.Generic;

namespace TrainTrack.Classes
{
    public interface IReader 
    {
        List<Train> ReadFile(string path);


    }
}
