using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Set this to be your project's NameSpace
namespace SimpleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            App theAPP = new App();
            theAPP.Test(); 
        }
    }

    public class App
    {
        public void Test()
        {
            Level1 L1 = new Level1();
            Level2 L2 = new Level2();
            Level3 L3 = new Level3();
            Level4A L4A = new Level4A();
            Level4B L4B = new Level4B();

            Console.WriteLine("TEST APPLICATION");

            Console.WriteLine("\nTESTING Level1");
            L1.Method1();

            Console.WriteLine("\nTESTING Level2");
            L2.Method1();
            L2.Method2();

            Console.WriteLine("\nTESTING Level3");
            L3.Method1();
            L3.Method2();
            L3.Method3();

            Console.WriteLine("\nTESTING Level4A");
            L4A.Method1();
            L4A.Method2();
            L4A.Method3();

            Console.WriteLine("\nTESTING Level4B");
            L4B.Method1();
            L4B.Method2();
            L4B.Method3();

            Pause(); 
        }

        public void Pause()
        {
            Console.WriteLine("\nHit Any Key To Continue...");
            Console.ReadKey(); 
        }

    }

}
