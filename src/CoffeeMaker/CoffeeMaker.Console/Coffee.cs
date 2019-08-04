using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker.ConsoleApp
{
    /// <summary>
    /// Это кофейный напиток.
    /// </summary>
    public class Coffee
    {
        /// <summary>
        /// Объём кофе.
        /// </summary>
        public int VolumeCoffee { get; set; }

        /// <summary>
        /// Крепость кофе.
        /// </summary>
        public int Strong { get; set; }

        /// <summary>
        /// Инициализируем коффейный напиток.
        /// </summary>
        /// <param name="volume"> Значения для поля объёма.</param>
        /// <param name="strong"> Значения для поля крепости.</param>
        public Coffee(int volume, int strong)
        {
            this.Strong = strong;
            this.VolumeCoffee = volume;
        }
    }
}
