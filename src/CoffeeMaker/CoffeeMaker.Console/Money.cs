using System;

namespace CoffeeMaker.ConsoleApp
{
    public struct Money
    {
        /// <summary>
        /// Копейки.
        /// </summary>
        private int _kopek;
        public Money(int kopek)
        {
            this._kopek = kopek;
        }

        public static implicit operator Money(int v)
        {
            return new Money(v);
        }
        public static explicit operator int(Money v)
        {
            throw new NotImplementedException();
        }
        public static Money operator +(Money first, Money second)
        {
            return first._kopek + second._kopek;
        }
        public override string  ToString()
        {
            return
                this._kopek.ToString();
        }
    }
}
