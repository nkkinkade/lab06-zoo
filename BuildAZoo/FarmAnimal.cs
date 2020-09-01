using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    public abstract class FarmAnimal : Animal
    {
        // Inherited Properties
        public override int Legs => 4;

        // FarmAnimal Properties 

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