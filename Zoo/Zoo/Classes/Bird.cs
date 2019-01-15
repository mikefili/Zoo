using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Bird : Animal
    {
        public override string diet { get; set; }
        public override int legs { get; set; }
        public virtual bool CanFly { get; set; }

        public abstract void Fly();
        public abstract void Migrate();
        public abstract void LayEggs();
    }
}
