using System;
using System.Collections.Generic;
using System.Text;
using TrainTrack.Classes;

namespace TrainTrack.Logging
{
    public abstract class LogBase
    {
        protected readonly object lockObj = new object();
        public abstract void Log(IController controller);
    }
}
