using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TrainTrack.Logging;

namespace TrainTrack.Classes
{
    public enum LogTarget
    {
        File, Database, EventLog
    }
    public class ControllerLog : LogBase
    {
        public string filePath = @"Data/controllerlog.txt";
        public override void Log(IController controller)
        {
            lock (lockObj)
            {
                using StreamWriter streamWriter = new StreamWriter(filePath);
                streamWriter.WriteLine(controller);
                streamWriter.Close();
            }
        }
    }
}
