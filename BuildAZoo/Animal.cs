using System;


namespace BuildAZoo
{
    public abstract class Animal
    {
        // Properties 
        public virtual int Legs { get; } = 2;
        public abstract bool HasFur { get; }

        // Methods
        public abstract string Eat();

        public abstract string Movement();

        public virtual string Sound()
        {
            return "grunt";
        }
    }
}
