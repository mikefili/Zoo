using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Animal
    {
        virtual public string Diet { get; set; }
        virtual public bool Tail { get; set; }
        virtual public int Legs { get; set; }

        abstract public void Eat();
        virtual public string Sleep()
        {
            return "ZZZ... ZZZ... ZZZ...";
        }
        abstract public string Sound();
    }
}
