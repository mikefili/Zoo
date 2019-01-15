using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Bird : Animal
    {
        public override string diet { get => base.diet; set => base.diet = "omnivore"; }
        public override int legs { get => base.legs; set => base.legs = 2; }
        public virtual bool canFly { get; set; }

        public abstract void Fly();
        public abstract void Migrate();
        public abstract void LayEggs();
    }
}
