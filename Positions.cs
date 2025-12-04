using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace MyConsole
{
    public class Positions
    {
        public Positions() 
        {
            Console.WriteLine("Номер сделки |" + "Операция       |" + "Цена    |" + "Кол-во  |" + "Объем позиции|" + "Ср. цена позиции |" );

           Timer timer = new Timer();

            timer.Interval = 1000;

            timer.Elapsed += Timer_Elapsed;

            timer.Start();

        }
        //==========================================================Fields=========================================================================
        #region Fields

        Random rnd = new Random();

        /// <summary>
        /// Суммарный объем позиции
        /// </summary>
        decimal PositionVolume = 0;

        /// <summary>
        /// Средняя цена позиции
        /// </summary>
        decimal PositionPrice = 0;
        /// <summary>
        /// Номер сделки
        /// </summary>
        int nTrade = 0;


        /// <summary>
        /// Направление сделки
        /// </summary>
        enum DirectTransaction
        {
            Купля,
            Продажа
        }
        #endregion

        //===========================================================Methods========================================================================
        #region Methods

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Trade trade = new Trade();


            int num = rnd.Next(-10, 10);

            byte i = 0;

            if (num > 0)
            {
                i = 0;
            }
            else if (num < 0)
            {
                i = 1;
            }
            else if (num == 0)
            {
                return;
            }

            nTrade++;

            trade.Volume = Math.Abs(num);

            trade.Price = rnd.Next(70000, 80000);

            if ((PositionVolume + num) != 0)
            {
                PositionPrice = (PositionPrice * PositionVolume + num * trade.Price) / (PositionVolume + num);
            }
            else 
            {
                PositionPrice = 0;
            }

            PositionVolume += num;                      //суммирует общую позицию


            Console.WriteLine(nTrade.ToString() + '\t' + '\t' + (DirectTransaction)i + '\t' + '\t' + trade.Price.ToString() + '\t' + trade.Volume.ToString() + '\t' + PositionVolume + '\t' + '\t' + Math.Round(PositionPrice,0));
        }
        #endregion
    }
} 
