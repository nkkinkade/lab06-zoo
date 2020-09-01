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
    }
}