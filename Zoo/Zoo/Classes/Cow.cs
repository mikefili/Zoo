using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Cow : Mammal
    {
        public override string diet { get => base.diet; set => base.diet = "herbivore"; }
        public override bool horned { get => base.horned; set => base.horned = true; }
        public override int stomachs { get => base.stomachs; set => base.stomachs = 4; }

        public abstract string PlowField();
        public abstract void Graze();
        public override string Sound()
        {
            string message = "Moo! Moo! Moo!";
            Console.WriteLine(message);
            return message;
        }
    }
}
