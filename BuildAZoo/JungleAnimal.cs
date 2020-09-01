using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    public abstract class JungleAnimal : Animal
    {
        // JungleAnimal Properties 

        public virtual string Temperament { get; } = "wild";

        // Inherited Methods

        public override string Movement()
        {
            return "walk";
        }

        public override string Eat()
        {
            return "fruit";
        }
    }
}