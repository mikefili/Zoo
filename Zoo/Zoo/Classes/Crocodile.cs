using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Crocodile : Reptile
    {
        public override string diet { get => base.diet; set => base.diet = "carnivore"; }
        public override bool shell { get => base.shell; set => base.shell = false; }
        public override bool tail { get => base.tail; set => base.tail = true; }

        public abstract void BirdTeethClean();
        public override void Eat()
        {
            Console.WriteLine("I like to eat meat!!!");
        }
        public override void Sleep()
        {
            Console.WriteLine("ZZZ... ZZZ... ZZZ... I like to sleep.");
        }
    }
}
