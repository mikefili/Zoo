using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class BlackBear : Bear
    {
        public override string color { get => base.color; set => base.color = "black"; }
        public override bool swims { get => base.swims; set => base.swims = false; }
        public override bool tail { get => base.tail; set => base.tail = true; }

        public abstract void ClimbTree();
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
