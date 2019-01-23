using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_1BExample
{
    class OtherApp:App
    {
        public override void TestMethod()
        {
            Console.WriteLine("Test Overide - Before Base Call");
            base.TestMethod();
            Console.WriteLine("Test Overide - After Base Call");
        }


    }
}
