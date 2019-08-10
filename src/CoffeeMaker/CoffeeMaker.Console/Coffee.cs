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
        public StrongType Strong { get; }

        /// <summary>
        /// Инициализируем коффейный напиток.
        /// </summary>
        /// <param name="volume"> Значения для поля объёма.</param>
        /// <param name="strong"> Значения для поля крепости.</param>
        /// <param name="price"> Значения для поля стоимости.</param>
        public Coffee(int volume, StrongType strong, Money price) : base(volume, price)
        {
            this.Strong = strong;
        }
    }
}
