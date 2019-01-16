using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Reptile : Animal
    {
        public override bool Tail { get => base.Tail; set => base.Tail = true; }
        public virtual bool Shell { get; set; }
        public virtual int Lifespan { get; set; }

        public abstract bool Hunt();
        public abstract bool Swim();
        public abstract void LayEggs();
    }
}
