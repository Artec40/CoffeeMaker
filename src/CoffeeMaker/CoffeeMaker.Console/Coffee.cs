using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker.ConsoleApp
{
    /// <summary>
    /// Это кофейный напиток.
    /// </summary>
    public class Coffee : Drink
    {
        /// <summary>
        /// Крепость кофе.
        /// </summary>
        public int Strong { get; }

        /// <summary>
        /// Инициализируем коффейный напиток.
        /// </summary>
        /// <param name="volume"> Значения для поля объёма.</param>
        /// <param name="strong"> Значения для поля крепости.</param>
        public Coffee(int volume, int strong) : base(volume)
        {
            this.Strong = strong;
        }
    }
}
