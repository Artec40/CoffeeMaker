using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMaker.ConsoleApp
{
    public abstract class Drink
    {
        /// <summary>
        /// Набор добавок к напитку.
        /// </summary>
        private IList<IAdditive> _additives = new List<IAdditive>();
        private Money _price;

        /// <summary>
        /// Объём напитка.
        /// </summary>
        public int Volume { get; }

        /// <summary>
        /// Цена напитка.
        /// </summary>
        public Money Price
        {
            get
            {
                var totalPrice = _price;
                foreach (var additive in _additives)
                {
                    totalPrice = totalPrice + additive.Price;
                }
                return totalPrice;
            }
        }

        /// <summary>
        /// Инициализируем объём напитка.
        /// </summary>
        /// <param name="volume"> Задаём значение объёма напитка.</param>
        /// <param name="price"> Задаём значение цены напитка.</param>
        public Drink(int volume, Money price)

        {
            this.Volume = volume;
            this._price = price;
        }
        public void AddAditive(IAdditive additive)
        {
            _additives.Add(additive);
        }

    }
}
