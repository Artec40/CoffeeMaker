using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker.ConsoleApp
{
    /// <summary>
    /// Это молоко.
    /// </summary>
    class Milk
    {
        /// <summary>
        /// Жирность молока.
        /// </summary>
        public double Fat { get; set; }

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
