using System;

namespace CoffeeMaker.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee cupcoffee1 = new Coffee(100, 8);
            Coffee cupcoffee2 = new Coffee(400, 3);
            Console.WriteLine($"cup of coffee 1: {cupcoffee1.VolumeCoffee}, {cupcoffee1.Strong}.");
            Console.WriteLine($"cup of coffee 2: {cupcoffee2.VolumeCoffee}, {cupcoffee2.Strong}.");

            Tea cuptea1 = new Tea(300, "Black");
            Tea cuptea2 = new Tea(300, "Green");
            Console.WriteLine($"cup of tea1: {cuptea1.VolumeTea}, {cuptea1.Type}.");
            Console.WriteLine($"cup of tea2: { cuptea2.VolumeTea}, {cuptea2.Type}.");

            Milk milk = new Milk(1.5);
            Console.WriteLine("Milk: ", milk.Fat);

            Console.WriteLine("Hello world!");
        }
    }
}
