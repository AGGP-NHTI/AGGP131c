using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExample
{
    class Program
    {
        static void Main(string[] args)
        {
            OtherApp theApp = new OtherApp();
            theApp.Test(); 
        }
    }

    public class App
    {
        public App()
        {
            Console.WriteLine("Da App!");
        }

        public App(string s)
        {
            Console.WriteLine("Da App says " + s + "!");
        }

        public void Pause()
        {
            Console.WriteLine("\nPress Any Key To Exit Applicaiton.");
            Console.ReadKey();
        }

        public virtual void Test()
        {
            Console.WriteLine("App Test");
            Pause();
        }
    }


    public class OtherApp : App
    {
        public override void Test()
        {
            Console.WriteLine("Before!");
            base.Test();
            Console.WriteLine("After!");
            Pause();
        }
    }

}
