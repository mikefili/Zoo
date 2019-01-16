using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Crocodile : Reptile
    {
        public override string Diet { get => base.Diet; set => base.Diet = "carnivore"; }
        public override bool Shell { get => base.Shell; set => base.Shell = false; }
        public override bool Tail { get => base.Tail; set => base.Tail = true; }

        public string BirdTeethClean()
        {
            return "Little birds clean my teeth!";
        }
        public override void Eat()
        {
            return;
        }

        public override bool Hunt()
        {
            return true;
        }

        public override void LayEggs()
        {
            return;
        }

        public override string Sleep()
        {
            return ("ZZZ... ZZZ... ZZZ...");
        }

        public override string Sound()
        {
            return "Hiss! Hiss! Hiss!";
        }

        public override bool Swim()
        {
            return true;
        }
    }
}
