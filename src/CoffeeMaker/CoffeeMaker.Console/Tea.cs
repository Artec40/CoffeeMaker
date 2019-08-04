using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker.ConsoleApp
{
    /// <summary>
    /// Это чаёк.
    /// </summary>
    public class Tea
    {
        ///  <summary>
        ///  Объём напитка. 
        ///  </summary>
        public int VolumeTea { get; set; }

        /// <summary>
        /// Тип чаёчка.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Инициализируем чаёк.
        /// </summary>
        /// <param name="volume"> Значения для поля объёма. </param> 
        /// <param name="type"> Значения для поля типа. </param>
        public Tea(int volume, string type)
        {
            this.VolumeTea = volume;
            this.Type = type;
        }
    }
}
