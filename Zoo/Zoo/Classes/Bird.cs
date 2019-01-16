using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Bird : Animal
    {
        public override string Diet { get => base.Diet; set => base.Diet = "omnivore"; }
        public override int Legs { get => base.Legs; set => base.Legs = 2; }
        public virtual bool CanFly { get; set; }

        public abstract void Fly();

        public abstract void Migrates();

        public abstract void LayEggs();
    }
}
