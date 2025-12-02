using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    public class Trade
    {
        //=============================================================Fields==================================================================

        #region Fields
        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price = 0;

        /// <summary>
        /// Название инструмента
        /// </summary>
        public string SecCode = "";

        /// <summary>
        /// код класса
        /// </summary>
        public string ClassCode = "";

        public DateTime DateTime = DateTime.MinValue;

        /// <summary>
        /// Номер счета
        /// </summary>
        public string Portfolio = "";


        /// <summary>
        /// Номер ордера
        /// </summary>
        static int OrderNumber = 0;

        /// <summary>
        /// Суммарный объем позиции
        /// </summary>
        decimal PositionVolume = 0;

        /// <summary>
        /// Средняя цена позиции
        /// </summary>
        decimal PositionPrice = 0;

        #endregion

        //=============================================================Properties==================================================================

        #region Properties
        /// <summary>
        /// Объем сделки
        /// Объем
        /// </summary>
        public decimal Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                _volume = value;
            }
            
        }
        decimal _volume = 0;
        #endregion


    }
}
