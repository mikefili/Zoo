using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Cow : Mammal
    {
        public override string Diet { get => base.Diet; set => base.Diet = "herbivore"; }
        public override bool Horned { get => base.Horned; set => base.Horned = true; }
        public override int Stomachs { get => base.Stomachs; set => base.Stomachs = 4; }

        public string PlowField()
        {
            return "I help plow the fields.";
        }

        public override string Sound()
        {
            return "Moo! Moo! Moo!";
        }

        public override bool Hibernate()
        {
            return false;
        }

        public override void Eat()
        {
            return;
        }
    }
}
