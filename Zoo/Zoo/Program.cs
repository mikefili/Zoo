using System;
using Zoo.Classes;

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

            Console.WriteLine(cow.PlowField());
            Console.WriteLine(blackbear.ClimbTree());
            Console.WriteLine(polarBear.Sleep());
            Console.WriteLine(ostrich.Sprint());
            Console.WriteLine(goose.Sound());
            Console.WriteLine(tortise.HideInShell());
            Console.WriteLine(crocodile.BirdTeethClean());
        }
    }
}
