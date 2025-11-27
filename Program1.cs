using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            levels = new List<decimal>();

            WriteLine();

            string str = ReadLine("Введите количество уровней: ");
            
            int contLevels = Convert.ToInt32(str);                   // количество уровней


            str = ReadLine("Задайте верхнюю цену: ");

            decimal priceUp = decimal.Parse(str);                   //значение верхней границы диапазона


            str = ReadLine("задайте нижнюю цену: ");

            decimal priceLower = decimal.Parse(str);                  //значение нижней границы диапазона

            str = ReadLine("задайте точность инструмента: ");

            int accTool = Convert.ToInt32(str);                       //кол. знаков после запятой



            decimal stepLevels = (priceUp - priceLower) / (contLevels-1);  //вычисление шага уровня

            stepLevels = Math.Round(stepLevels,accTool);                        //приведение шага к заданной точности

           
            Console.WriteLine("Шаг уровня: " + stepLevels);


            decimal priceLevels = priceUp;

            for (int i = 0; i < contLevels; i++)                 //цикл присваивания значений элементам списка
            {
                if (i != (contLevels - 1))
                {
                    levels.Add(priceLevels);                //присваивания значений элементам списка кроме последнего !rytryt
                    priceLevels -= stepLevels;
                }
                else
                {
                    levels.Add(priceLower);                // присваивание значения нижней границы диапазано последнему элементу списка
                }
            }
            
            WriteLine();
            
        }

        static List<decimal>levels;
        static void WriteLine()
        {
            Console.WriteLine("Количество элементов в списке: " + levels.Count.ToString());

            for (int i = 0; i < levels.Count; i++)
            {
                Console.WriteLine("Уровень "+ (i+1) + " = " + levels[i]);

            }
        }

        static string ReadLine(string message)
        {
            Console.WriteLine(message);
            string str = Console.ReadLine();
            return str;
        }
    }
}
