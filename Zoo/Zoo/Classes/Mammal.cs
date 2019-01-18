using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Mammal : Animal
    {
        public override int Legs { get => base.Legs; set => base.Legs = 4; }
        virtual public int Stomachs { get; set; }
        virtual public bool Horned { get; set; }

        virtual public string Birth()
        {
            return "I give live birth.";
        }
        virtual public void Nurse()
        {
            return;
        }
        virtual public bool Hibernate()
        {
            return true;
        }
    }
}
