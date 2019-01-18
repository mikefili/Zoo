using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Ostrich : Bird , IRace
    {
        public override bool CanFly { get => base.CanFly; set => base.CanFly = false; }
        public override bool Tail { get => base.Tail; set => base.Tail = true; }
        public virtual int Height { get; set; }
        public bool WearBlinders { get; set; } = true;

        public string Sprint()
        {
            return ("I run really fast!!!");
        }
        public bool BuryHead()
        {
            return true;
        }

        public override void Fly()
        {
            return;
        }

        public override void Migrates()
        {
            return;
        }

        public override void LayEggs()
        {
            return;
        }

        public override string Eat()
        {
            return "I like to eat bugs!!!";
        }

        public override string Sound()
        {
            return "Wenk! Wenk! Wenk!";
        }

        public string Race()
        {
            return "I am the fastest bird on Earth!";
        }
    }
}
