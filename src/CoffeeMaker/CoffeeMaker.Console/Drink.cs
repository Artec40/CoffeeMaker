using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker.ConsoleApp
{
    public abstract class Drink
    {
        /// <summary>
        /// Объём напитка.
        /// </summary>
        public int Volume { get; }

        /// <summary>
        /// Инициализируем объём напитка.
        /// </summary>
        /// <param name="volume"> Задаём значение объёма напитка.</param>
        public Drink(int volume)
        {
            this.Volume = volume;
        }
    }
}
