using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class BlackBear : Bear
    {
        public override string Color { get => base.Color; set => base.Color = "black"; }
        public override bool Swims { get => base.Swims; set => base.Swims = false; }
        public override bool Tail { get => base.Tail; set => base.Tail = true; }
        public override int Stomachs { get => Stomachs; set => Stomachs = 1; }

        public override void Birth()
        {
            Console.WriteLine("I have to nurse my young.");
        }

        public string ClimbTree()
        {
            return "Let's climb a tree!";
        }

        public override void Eat()
        {
            Console.WriteLine("I like to eat meat!!!");
        }

        public override string Sleep()
        {
            return ("ZZZ... ZZZ... ZZZ...");
        }
    }
}
