using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Goose : Bird
    {
        public override bool canFly { get => base.canFly; set => base.canFly = true; }
        public override bool tail { get => base.tail; set => base.tail = true; }
        public abstract bool migrate { get; set; }

        public override void Eat()
        {
            Console.WriteLine("I like to eat bread!!!");
        }
        public override string Sound()
        {
            string message = "Quack! Quack! Quack!";
            Console.WriteLine(message);
            return message;
        }
    }
}
