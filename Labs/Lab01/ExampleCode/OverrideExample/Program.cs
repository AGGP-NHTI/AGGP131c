
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_1BExample
{
    class Program
    {
        static void Main(string[] args)
        {
            App theApp = new App();
            theApp = new OtherApp();
            theApp.TestMethod();
            theApp.Pause();

        }
    }
}
