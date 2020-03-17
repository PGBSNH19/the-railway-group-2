using System.Collections.Generic;

namespace TrainTrack.Classes
{
    public interface IGenericList<T> 
    {
        public string FilePath { get; set; }
        List<T> ReadFile();
    }
}