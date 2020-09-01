using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    public abstract class Dog : FarmAnimal
    {
        // Inherited Properties
        public override int Legs => 4;

        // Inherited Methods
        public override bool HasFur
        {
            get { return true; }
        }
        public override string Movement()
        {
            return "walk/run";
        }

        public override string Sound()
        {
            return "woof";
        }

        public override string Eat()
        {
            return "dog food";
        }
    }
}