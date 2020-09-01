using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    public abstract class Elephant : JungleAnimal
    {
        // Inherited Properties
        public override int Legs => 4;

        // Inherited Methods
        public override bool HasFur
        {
            get { return false; }
        }

        public override string Sound()
        {
            return "trumpet";
        }
    }
}