using System;
using System.Collections.Generic;
using System.Text;
using TrainTrack.Classes;

namespace TrainTrack.Logging
{
    public static class LogHelper
    {
        private static LogBase logger = null;
        public static void Log(LogTarget target, IController controller)
        {
            switch (target)
            {
                case LogTarget.File:
                    logger = new ControllerLog();
                    logger.Log(controller);
                    break;
                case LogTarget.Database:
                    
                    break;
                case LogTarget.EventLog:
                    
                    break;
                default:
                    return;
            }
        }
    }
}
