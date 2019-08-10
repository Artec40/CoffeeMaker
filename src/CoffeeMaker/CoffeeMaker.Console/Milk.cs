using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker.ConsoleApp
{
    /// <summary>
    /// Это молоко.
    /// </summary>
    public class Milk : IAdditive
    {
        public Money Price { get; } = 20;

        /// <summary>
        /// Жирность молока.
        /// </summary>
        public double Fat { get; }

        /// <summary>
        /// Инициализируем молоко.
        /// </summary>
        /// <param name="fat"> Значения для жирности молока. </param> 
        public Milk(double fat)
        {
            this.Fat = fat;
        }
    }
}
