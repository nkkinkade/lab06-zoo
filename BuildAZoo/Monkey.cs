using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    public abstract class Monkey : JungleAnimal
    {
        // Inherited Methods
        public override bool HasFur
        {
            get { return true; }
        }
        public override string Movement()
        {
            return "jump/climb";
        }

        public override string Sound()
        {
            return "ooo ooo eee eee";
        }

        // Monkey method
        public string Tail()
        {
            return "I have a long tail, but some of my cousins have short tails.";
        }
    }
}