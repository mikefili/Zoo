using System;
using Zoo.Classes;
using Zoo.Interfaces;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Zoo!");

            Cow cow = new Cow();
            BlackBear blackbear = new BlackBear();
            PolarBear polarBear = new PolarBear();
            Ostrich ostrich = new Ostrich();
            Goose goose = new Goose();
            Tortise tortise = new Tortise();
            Crocodile crocodile = new Crocodile();

            Console.WriteLine($"Cow: {cow.PlowField()}");
            Console.WriteLine($"Black Bear: {blackbear.ClimbTree()}");
            Console.WriteLine($"Polar Bear: {polarBear.Sleep()}");
            Console.WriteLine($"Polar Bear: {polarBear.Prey}");
            Console.WriteLine($"Polar Bear: {polarBear.HuntingGround()}");
            Console.WriteLine($"Ostrich: {ostrich.Sprint()}");
            Console.WriteLine($"Ostrich: {ostrich.Race()}");
            Console.WriteLine($"Ostrich: When I race, do I wear blinders? {ostrich.WearBlinders}");
            Console.WriteLine($"Goose: {goose.Sound()}");
            Console.WriteLine($"Tortise: {tortise.HideInShell()}");
            Console.WriteLine($"Crocodile: {crocodile.BirdTeethClean()}");
        }
    }
}
