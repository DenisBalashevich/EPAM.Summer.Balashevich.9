using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerTask
{
    /// <summary>
    /// Information about event
    /// </summary>
    public sealed class EndMatchEventArgs : EventArgs
    {
        #region ctor

        public EndMatchEventArgs() { }

        public EndMatchEventArgs(DateTime startTime, DateTime finishTime, int miliseconds, string message)
        {
            StartTime = startTime;
            TimerTime = miliseconds;
            FinishTime = finishTime;
            Message = message;
        }
        #endregion
        #region properties
        public DateTime StartTime { get; }
        public DateTime FinishTime { get; }
        public int TimerTime { get; }
        public string Message { get; }
        #endregion
    }
}
