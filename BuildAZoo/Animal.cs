using System;
using Xunit;


namespace BuildAZoo
{
    public abstract class Animal
    {
        // Properties 
        public virtual int Legs { get; } = 2;
        public abstract string Color { get; }

        // Methods
        public abstract string Eat();

        public abstract string Movement();

        public virtual string Sound()
        {
            return "grunt";
        }

    }
}
