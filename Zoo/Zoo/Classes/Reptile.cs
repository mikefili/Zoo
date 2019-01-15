using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Reptile : Animal
    {
        public override bool tail { get => base.tail; set => base.tail = true; }
        public virtual bool shell { get; set; }
        public abstract int lifespan { get; set; }

        public abstract void Hunt();
        public abstract bool Swim();
        public abstract void LayEggs();
    }
}
