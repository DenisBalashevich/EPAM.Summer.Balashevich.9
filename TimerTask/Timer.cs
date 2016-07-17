using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TimerTask
{
    /// <summary>
    /// Timer is mail manager
    /// </summary>
    public class Timer
    {
        public event EventHandler<EndMatchEventArgs> EndTime = delegate { };

        protected virtual void OnNewMail(EndMatchEventArgs e)
        {
            EventHandler<EndMatchEventArgs> temp = EndTime;

            if (temp != null)
            {
                temp(this, e);
            }
        }

        /// <summary>
        /// Start Timer
        /// </summary>
        /// <param name="miliseconds">Timer time</param>
        /// <param name="message">Few words</param>
        public void Start(int miliseconds, string message)
        {
            DateTime start = DateTime.Now;
            Thread.Sleep(miliseconds);
            OnNewMail(new EndMatchEventArgs(start, DateTime.Now, miliseconds, message));
        }
    }
}
