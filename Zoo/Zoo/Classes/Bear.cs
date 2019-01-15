using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Bear : Mammal
    {
        public override string diet { get => base.diet; set => base.diet = "carnivore"; }
        public virtual string color { get; set; }
        public virtual bool swims { get; set; }

        public override bool Hibernate()
        {
            return true;
        }
        public override string Sound()
        {
            string message = "Roar! Roar! Roar!";
            Console.WriteLine(message);
            return message;
        }
    }
}
