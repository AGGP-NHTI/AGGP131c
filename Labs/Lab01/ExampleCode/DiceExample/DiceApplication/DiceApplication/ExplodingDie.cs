using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    public class ExplodingDie : Die
    {

        public ExplodingDie() : base()
        { }

        public ExplodingDie(int NumberofSides) : base(NumberofSides)
        { }

        // Overloaded Roll Method
        public override int Roll()
        {
            int result = 0;
            int lastroll= 0;
            do
            {
                lastroll = base.Roll();
                result += lastroll; 

            } while (lastroll == NumberOfSides);
             
            return result;
        }

    }
}
