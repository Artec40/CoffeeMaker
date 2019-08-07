using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker.ConsoleApp
{
    public class Mouse
    {
        public virtual string Roar(string textToRoar)
        {
            if (string.IsNullOrEmpty(textToRoar))
                return "RRRRRRRRRR";
            return textToRoar;
        }
        public void Dead()
        {
            Roar("you Died");
        }
    }
}
