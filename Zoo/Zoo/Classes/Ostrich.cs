using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Ostrich : Bird
    {
        public override bool CanFly { get => base.CanFly; set => base.CanFly = false; }
        public override bool Tail { get => base.Tail; set => base.Tail = true; }
        public virtual int Height { get; set; }

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

        public override void Eat()
        {
            return;
        }

        public override string Sound()
        {
            return "Wenk! Wenk! Wenk!";
        }
    }
}
