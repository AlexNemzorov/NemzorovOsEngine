using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace MyConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Positions positions = new Positions();

            /* levels = new List<Level>();

             WriteLine();

             string str = ReadLine("Введите количество уровней: ");


             contLevels = Convert.ToInt32(str);                   // количество уровней


             str = ReadLine("Задайте верхнюю цену: ");

             priceUp = decimal.Parse(str);                   //значение верхней границы диапазона


             str = ReadLine("задайте нижнюю цену: ");

             priceLower = decimal.Parse(str);                  //значение нижней границы диапазона


             str = ReadLine("задайте точность инструмента: ");

             int accTool = Convert.ToInt32(str);                       //кол. знаков после запятой




             levels = Level.CalculateLevels(priceUp, priceLower, contLevels, accTool);

             WriteLine();
            */

           Console.ReadLine();
        }

        //==========================================================Fields=========================================================================
        #region Fields

        /// <summary>
        /// Список уровней
        /// </summary>
        static List<Level>levels;

        /// <summary>
        /// Количество уровней
        /// </summary>
        static int contLevels;

        /// <summary>
        /// значение верхней границы диапазона
        /// </summary>
        static decimal priceUp;

        /// <summary>
        /// Значение нижней границы диапазона
        /// </summary>
        static decimal priceLower;

        /// <summary>
        /// шаг уровня
        /// </summary>
       // static decimal stepLevels;

        #endregion

        //===========================================================Methods========================================================================
        #region Methods

        static void WriteLine()
        {
            Console.WriteLine("Количество элементов в списке: " + levels.Count.ToString());

            for (int i = 0; i < levels.Count; i++)
            {
                Console.WriteLine("Уровень "+ (i+1) + " = " + levels[i].PriceLevel);

            }
        }

        static string ReadLine(string message)
        {
            Console.WriteLine(message);
            string str = Console.ReadLine();
            return str;
        }

        #endregion

    }
}
