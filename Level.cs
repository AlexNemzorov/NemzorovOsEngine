using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    public class Level
    {
        //=============================================================Fields==================================================================
        #region Fields

        /// <summary>
        /// Цена уровня
        /// </summary>
        public decimal PriceLevel = 0;

        /// <summary>
        /// Количество лотов на уровне
        /// </summary>
        public decimal LotLevel = 0;

        /// <summary>
        /// Объем на уровне
        /// </summary>
        public decimal Volume = 0;

        #endregion

        //=============================================================Fields==================================================================
        #region Fields

        public static List<Level> CalculateLevels(decimal priceUp, decimal priceLower, int count, int accTool)
        {
            decimal stepLevels = (priceUp - priceLower) / (count - 1);  //вычисление шага уровня

            stepLevels = Math.Round(stepLevels, accTool);                        //приведение шага к заданной точности


            Console.WriteLine("Шаг уровня: " + stepLevels);

            List<Level> levels = new List<Level>();

            decimal priceLevels = priceUp;

            for (int i = 0; i < count; i++)                 //цикл присваивания значений элементам списка
            {
                Level level = new Level();

                if (i != (count - 1))
                {
                    level.PriceLevel = priceLevels;                //присваивания значений элементам списка кроме последнего !

                    levels.Add(level);

                    priceLevels -= stepLevels;
                }
                else
                {
                    level.PriceLevel = priceLower;                // присваивание значения нижней границы диапазано последнему элементу списка

                    levels.Add(level);
                }

            }
            return levels;

        }
        #endregion
    }
}
