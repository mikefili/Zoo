using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Animal
    {
        public virtual string diet { get; set; }
        public virtual bool tail { get; set; }
        public virtual int legs { get; set; }

        public abstract void Eat();
        public abstract void Sleep();
        public abstract string Sound();
    }
}
