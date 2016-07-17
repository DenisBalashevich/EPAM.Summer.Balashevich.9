using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimerTask;

namespace TimerTastTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer manager = new Timer();
            var boy = new Boy();
            boy.Register(manager);
            var sport = new Sportsmen();
            sport.Register(manager);
            manager.Start(2000, "Go!");
        }
    }
}
