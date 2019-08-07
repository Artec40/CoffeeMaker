using System;

namespace CoffeeMaker.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var smallDrink = new Coffee(100, 8);
            var bigDrink = new Coffee(400, 3);
            Console.WriteLine($"cup of coffee 1: {smallDrink.Volume}, {smallDrink.Strong}.");
            Console.WriteLine($"cup of coffee 2: {bigDrink.Volume}, {bigDrink.Strong}.");

            var cupOfBlackTea = new Tea(300, "Black");
            var cupOfGreenTea = new Tea(300, "Green");
            Console.WriteLine($"cup of tea 1: {cupOfBlackTea.Volume}, {cupOfBlackTea.Type}.");
            Console.WriteLine($"cup of tea 2: {cupOfGreenTea.Volume}, {cupOfGreenTea.Type}.");

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
