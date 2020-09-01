using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    public abstract class Pig : FarmAnimal
    {
        // Inherited Properties
        public override int Legs => 4;

        // Inherited Methods
        public override bool HasFur
        {
            get { return false; }
        }
        public override string Movement()
        {
            return "walk";
        }

        public override string Sound()
        {
            return "oink";
        }

        public override string Eat()
        {
            return "slop";
        }
    }
}