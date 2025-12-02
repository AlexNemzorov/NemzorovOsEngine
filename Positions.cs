using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace MyConsole
{
    public class Positions
    {
        public Positions() 
        {
           System.Timers.Timer timer = new System.Timers.Timer();

            timer.Interval = 1000;

            timer.Elapsed += Timer_Elapsed;

            timer.Start();

        }

        Random rnd = new Random();

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Trade trade = new Trade();

            int num = rnd.Next(-10, 10);

            if (num > 0)
            {
                // long
            }
            else if (num < 0)
            { 
                //short
            }

            trade.Volume = Math.Abs(num);

            trade.Price = rnd.Next(7000, 8000);


            string str = "Volume = " +trade.Volume.ToString() + "/ Price = " + trade.Price.ToString();

            Console.WriteLine(str);
        }
    }
}
