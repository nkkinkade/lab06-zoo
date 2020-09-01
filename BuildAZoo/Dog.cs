using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    public abstract class Dog : FarmAnimal
    {
        // Inherited Properties
        public override int Legs => 4;

        // Dog Properties 
        public abstract string FurType { get; }

        public virtual string Temperament { get; } = "calm";

        // Inherited Methods

        public override string Movement()
        {
            return "walk";
        }

        public override string Eat()
        {
            return "dog food";
        }
    }
}