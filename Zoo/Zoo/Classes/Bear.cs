using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Bear : Mammal
    {
        public override string Diet { get => base.Diet; set => base.Diet = "carnivore"; }
        public virtual string Color { get; set; }
        public virtual bool Swims { get; set; }

        public void Fishing()
        {
            return;
        }

        public override bool Hibernate()
        {
            return true;
        }

        public override string Sound()
        {
            return "Roar! Roar! Roar!";
        }
    }
}
