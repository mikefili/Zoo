using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Ostrich : Bird
    {
        public override bool canFly { get => base.canFly; set => base.canFly = false; }
        public override bool tail { get => base.tail; set => base.tail = true; }
        public virtual int height { get; set; }

        public void Sprint()
        {
            Console.WriteLine("I run really fast!!!");
        }
        public abstract bool BuryHead();
        public abstract int Grow();
    }
}
