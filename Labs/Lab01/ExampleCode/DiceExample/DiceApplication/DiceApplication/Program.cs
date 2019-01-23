using System;
using System.Text;
using Dice;  //  Dice is the Namespace we've created for our Dice Class

namespace DiceApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // The  main function is static. Meaning there's only one in existance. 
            // It also means we can't use class members. 
            // so we move to a new class to get around it. 
            DiceApp DiceProgram = new DiceApp(); 
        }
    }

    public class DiceApp
    {
        // Default Constructor
        public DiceApp()
        {
            Console.WriteLine("***************");
            Console.WriteLine("Dice Test Application");
            Console.WriteLine("");

            // Create Dice references

            Die D6 = new Die(); TimeDelay(); 
            Die D6A = new Die(); TimeDelay();

            Die D10 = new Die(10); TimeDelay();
            Die ED6 = new ExplodingDie(); TimeDelay();
            Die ED10 = new ExplodingDie(10); TimeDelay();
            Die CD6 = new CrookedDie(); TimeDelay();
            Die CD10 = new CrookedDie(10); TimeDelay();
            Die CED6 = new CrookedExplodingDie(); TimeDelay();
            Die CED10 = new CrookedExplodingDie(10); TimeDelay();


            // Testing Die Class
            Console.WriteLine("Testing Die Class");
            TestDie(D6, "D6 ", 10);
            TestDieDetailed(D6A, "D6A", 10);
            TestDie(D10, "D10", 10);
            Console.WriteLine("");

            Console.WriteLine("Testing Exploding Die Class");
            TestDie(ED6, "ED6 ", 10);
            TestDieDetailed(ED6, "ED6", 10);
            TestDie(ED10, "ED10 ", 10);
            TestDieDetailed(D10, "ED10", 10);
            Console.WriteLine("");

            // Testing Crooked Die Class
            Console.WriteLine("Testing Crooked Die Class");
            TestDie(CD6, "cD6 ", 10);
            TestDieDetailed(CD6, "CD6", 10);
            TestDie(CD10, "CD10 ", 10);
            TestDieDetailed(CD10, "CD10", 10);
            Console.WriteLine("");

            // Testing Crooked Exploding Die Class
            Console.WriteLine("Testing Crooked Exploding Die Class");
            TestDie(CED6, "CED6 ", 10);
            TestDieDetailed(CED6, "CED6", 10);
            TestDie(CED10, "CED10 ", 10);
            TestDieDetailed(CED10, "CED10", 10);
            Console.WriteLine("");

            // Wait for user to exit app
            // Need to do this or window will close. 
            Console.Write("\nPress Any Key to Exit");
            // We don't care what key we get, just that we get one. 
            Console.ReadKey(); 
            
            //When code Reaches Here, App will terminate.  

        }

        // What makes these next two methods possibile is
        // when you create a new class or struct, you create a new type
        // You can use them as you can a bool, int, float, and string. 

        void TestDie(Die TestDie, String Header, int NumberOfRolls)
        {
            Console.Write(Header + ":");
            int lastroll = 0; 
            for (int i = 0; i < NumberOfRolls; i++)
            {
                lastroll = TestDie.Roll(); 
                Console.Write(" " + lastroll);
            }
            Console.Write("\n");

        }

        void TestDieDetailed(Die TestDie, String Header, int NumberOfRolls)
        {
            RollDetails lastroll;
          
            lastroll = TestDie.Roll(NumberOfRolls);
            Console.Write(Header + ":");

            Console.Write(" " + lastroll.Value);
            Console.Write(" (" + lastroll.Details + " )\n");
        }

        public void TimeDelay()
        {
      
            // the Random Class is seeded based on the computer time 
            // This function makes a "time Delay" so that we'll get another seed. 
            // This is a dirty dirty hack... 
            for (int i=0; i<10000000; i++)
            {
                // twiddle thumbs. 
            }
        }

    }

}