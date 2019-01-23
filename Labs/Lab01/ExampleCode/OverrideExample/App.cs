using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_1BExample
{
    public class App
    {
        public void Pause()
        {
            Console.WriteLine("\nPress Any Key...");
            Console.ReadKey();
        }

        public virtual void TestMethod()
        {
            // do work here... 
            Console.WriteLine("TestMethod Called");


        }
    }
}
