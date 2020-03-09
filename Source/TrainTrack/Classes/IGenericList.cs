using System;
using System.Collections.Generic;

namespace TrainTrack.Classes
{
    public interface IGenericList<T> 
    {
        List<T> ReadFile(string path);

    }
}
