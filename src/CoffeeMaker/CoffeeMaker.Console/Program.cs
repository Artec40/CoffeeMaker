using System;
using System.Collections.Generic;

namespace CoffeeMaker.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose your drink: coffee, tea.");
            while (true)
            {
                ChooseDrink();
            }
        }
        static void WriteColorLine(string messageText, ConsoleColor consoleColor)
        {
            var currentConsoleColor = Console.ForegroundColor;
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(messageText);
            Console.ForegroundColor = currentConsoleColor;
        }

        static void ChooseDrink()
        {
            var command = Console.ReadLine();
            switch (command)
            {
                case "coffee":
                    Console.WriteLine("you choose coffee.");
                    CreateCoffee();

                    break;
                case "tea":
                    Console.WriteLine("you choose tea.");
                    var cupOfTea = new Tea(250, "Black", 80);
                    break;
                default:
                    WriteColorLine("Bad command, try again later.", ConsoleColor.Red);
                    break;
            }
        }

        static void CreateCoffee()
        {
            Console.WriteLine("Volume? - 100, 250");
            var volume = Console.ReadLine();
            var cupOfCoffee = new Coffee(Convert.ToInt32(volume), StrongType.Hard, 100);
            Console.WriteLine($"Your price {cupOfCoffee.Price}");

            Console.WriteLine("Additive? - milk, cinnamon, sugar");
            var additive = Console.ReadLine();
            switch (additive)
            {
                case "milk":
                    Console.WriteLine("you choose milk.");
                    var milk = new Milk(2.5);
                    cupOfCoffee.AddAditive(milk);
                    break;
                case "cinnamon":
                    Console.WriteLine("you choose cinnamon.");
                    var cinnamon = new Cinnamon();
                    cupOfCoffee.AddAditive(cinnamon);
                    break;
                case "sugar":
                    Console.WriteLine("you choose sugar.");
                    var sugar = new Sugar();
                    cupOfCoffee.AddAditive(sugar);
                    break;
            }
            Console.WriteLine($"Your price {cupOfCoffee.Price}");
        }
    }
}
