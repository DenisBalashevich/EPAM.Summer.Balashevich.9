using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerTask
{
    /// <summary>
    /// HE IS listener
    /// </summary>
    public sealed class Sportsmen
    {
        private void FaxMsg(Object sender, EndMatchEventArgs eventArgs)
        {
            Console.WriteLine("Timer {0} miliseconds is end , {1}", eventArgs.TimerTime, eventArgs.Message);
        }

        public void Register(Timer mail)
        {
            mail.EndTime += FaxMsg;
        }

        public void Unregister(Timer mail)
        {
            mail.EndTime -= FaxMsg;
        }
    }
}
