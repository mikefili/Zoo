using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class PolarBear : Bear , IHunt
    {
        public override string Color { get => base.Color; set => base.Color = "white"; }
        public override bool Swims { get => base.Swims; set => base.Swims = true; }
        public override bool Tail { get => base.Tail; set => base.Tail = true; }
        public override int Stomachs { get => Stomachs; set => Stomachs = 4; }
        public string Prey { get; set; } = "fish & small mammals";

        public void Swim()
        {
            return;
        }
        public override string Eat()
        {
            return "I like to eat meat!!!";
        }
        public override string Sleep()
        {
            return ("ZZZ... ZZZ... ZZZ...");
        }

        public override string Birth()
        {
            return "I have to nurse my young.";
        }

        public override void Nurse()
        {
            return;
        }

        public string HuntingGround()
        {
            return "Underwater & on land";
        }
    }
}
