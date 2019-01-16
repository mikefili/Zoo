using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Tortise : Reptile
    {
        public override string Diet { get => base.Diet; set => base.Diet = "herbivore"; }
        public override bool Shell { get => base.Shell; set => base.Shell = true; }
        public override int Lifespan { get => base.Lifespan; set => base.Lifespan = 100; }

        public string HideInShell()
        {
            return "I hide in my shell when there is danger";
        }
        public override void Eat()
        {
            return;
        }
        public override string Sleep()
        {
            return ("ZZZ... ZZZ... ZZZ...");
        }

        public override bool Swim()
        {
            return false;
        }

        public override void LayEggs()
        {
            return;
        }

        public override string Sound()
        {
            return "Tuuuuurtle, tuuuuuurtle.";
        }

        public override bool Hunt()
        {
            return false;
        }
    }
}
