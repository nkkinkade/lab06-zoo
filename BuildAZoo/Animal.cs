using System;
using Xunit;


namespace BuildAZoo
{
    public abstract class Animal
    {
        //public abstract string Eat { get; }

        //public abstract string Sound { get; }

        public abstract bool HasFur { get; }
        public abstract int NumberOfLegs { get; }
        public string Size { get; protected set; }


    }
}
