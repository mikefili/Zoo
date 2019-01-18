using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Goose : Bird
    {
        public override bool CanFly { get => base.CanFly; set => base.CanFly = true; }
        public override bool Tail { get => base.Tail; set => base.Tail = true; }
        public bool Migrate { get; set; } = true;

        public override string Eat()
        {
            return "I like to eat bread!!!";
        }

        public override void Fly()
        {
            return;
        }

        public override void LayEggs()
        {
            return;
        }

        public override void Migrates()
        {
            return;
        }

        public override string Sound()
        {
            return "Quack! Quack! Quack!";
        }
    }
}
