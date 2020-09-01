using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    public abstract class FarmAnimal : Animal
    {
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