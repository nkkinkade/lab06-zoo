using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    public abstract class Cow : FarmAnimal
    {
        // Inherited Properties
        public override int Legs => 4;

        // Inherited Methods
        public override bool HasFur
        {
            get { return true; }
        }

        public override string Sound()
        {
            return "moo";
        }

        public override string Eat()
        {
            return "hay";
        }

        // cow method
        public string Tail()
        {
            return "I have a long tail";
        }
    }
}