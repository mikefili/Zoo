using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class PolarBear : Bear
    {
        public override string color { get => base.color; set => base.color = "white"; }
        public override bool swims { get => base.swims; set => base.swims = true; }
        public override bool tail { get => base.tail; set => base.tail = true; }

        public abstract void Swim();
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
