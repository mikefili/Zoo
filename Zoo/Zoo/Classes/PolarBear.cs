using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class PolarBear : Bear
    {
        public override string Color { get => base.Color; set => base.Color = "white"; }
        public override bool Swims { get => base.Swims; set => base.Swims = true; }
        public override bool Tail { get => base.Tail; set => base.Tail = true; }
        public override int Stomachs { get => Stomachs; set => Stomachs = 4; }

        public void Swim()
        {
            return;
        }
        public override void Eat()
        {
            Console.WriteLine("I like to eat meat!!!");
        }
        public override string Sleep()
        {
            return ("ZZZ... ZZZ... ZZZ...");
        }

        public override void Birth()
        {
            return;
        }

        public override void Nurse()
        {
            return;
        }
    }
}
