using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Tortise : Reptile
    {
        public override string diet { get => base.diet; set => base.diet = "herbivore"; }
        public override bool shell { get => base.shell; set => base.shell = true; }
        public override int lifespan { get => base.lifespan; set => base.lifespan = 100; }

        public abstract void HideInShell();
        public override void Eat()
        {
            Console.WriteLine("I like to eat plants!!!");
        }
        public override void Sleep()
        {
            Console.WriteLine("ZZZ... ZZZ... ZZZ... I like to sleep.");
        }
    }
}
