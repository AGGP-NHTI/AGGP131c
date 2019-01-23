using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice  
{
    class CrookedDie : Die
    {
        public CrookedDie() : base()
        { }

        public CrookedDie(int NumberofSides) : base(NumberofSides)
        { }

        protected override double Sample()
        {
            double result = base.Sample();

            // We're going to Skew just a little
            result += (1.0 / (2.0 * NumberOfSides));
            
            // if our value is above 1, set it to .99999 to keep it within range
            if (result >= 1.0)
            {
                result = .99999; 
            } 

            return result; 
        }
    }
}
