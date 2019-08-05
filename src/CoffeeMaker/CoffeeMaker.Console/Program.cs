using System;

namespace CoffeeMaker.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var drink1 = new Coffee(100, 8);
            var drink2 = new Coffee(400, 3);
            Console.WriteLine($"cup of coffee 1: {drink1.Volume}, {drink1.Strong}.");
            Console.WriteLine($"cup of coffee 2: {drink2.Volume}, {drink2.Strong}.");

            var cupoftea1 = new Tea(300, "Black");
            var cupoftea2 = new Tea(300, "Green");
            Console.WriteLine($"cup of tea1: {cupoftea1.Volume}, {cupoftea1.Type}.");
            Console.WriteLine($"cup of tea2: {cupoftea2.Volume}, {cupoftea2.Type}.");

            var milk = new Milk(1.5);
            Console.WriteLine($"Milk:, {milk.Fat}.");

            var mouse = new Mouse();
            Console.WriteLine(mouse.Roar(string.Empty));

            var mouse2 = new LittleMouse();
            Console.WriteLine(mouse2.Roar(string.Empty));
            Console.WriteLine("Hello world!");
        }
    }
}
