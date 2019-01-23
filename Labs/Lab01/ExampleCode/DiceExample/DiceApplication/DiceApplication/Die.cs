using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    // Our Dice Class will Inherit from Random. 
    public class Die : Random
    {
        protected int NumberOfSides;          // How Many Sides our die has. 
        public const int DEFAULTSIDES = 6;  // Default is D6, Six-Sided Die


        // Creating DieSides as a Property 
        protected int DieSides
        {
            get { return NumberOfSides; }
            set { SetSides(value);  }
        }

        // Default Constructor
        public Die()
        {
            SetSides(DEFAULTSIDES); 
        }

        // Overloaded Constructor
        public Die(int Sides)
        {
            SetSides(Sides);
        }

        // We've chosen to hide our Variable NumberofSides as private. 
        // And instead chosen to expose it through this method instead. 
        // We're doing this so we'll always have a value that is valid and makes sense. 
        // This is called "Encapsulation" 

        public void SetSides(int Sides)
        {
            if (Sides < 3)
            {
                NumberOfSides = DEFAULTSIDES; 
            }
            NumberOfSides = Sides;
        }

        public virtual int Roll()
        {
            return (int)(NumberOfSides * Sample())+1 ;      // Standard Die 
            // We are using Sample because later we'll use it later for the crooked dice
        }

        public virtual RollDetails Roll(int NumberOfRolls)
        {
            // Getting an Instandce of the RollDetails Struct
            RollDetails result = new RollDetails(); 
            
            // We have an instance of the struct, just initalizing to be safe 
            result.Value = 0;
            result.Details = "";

            int lastroll; 
            for (int i = 0; i < NumberOfRolls; i++)
            {
                lastroll = Roll();
                result.Value += lastroll;
                result.Details += " " + lastroll;
            }
            return result; 
        }

    }
}
