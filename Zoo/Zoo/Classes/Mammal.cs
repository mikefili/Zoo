using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Mammal : Animal
    {
        public override int legs { get; set; }
        public virtual int stomachs { get; set; }
        public virtual bool horned { get; set; }

        public abstract void Birth();
        public abstract void Nurse();
        public abstract bool Hibernate();
    }
}
