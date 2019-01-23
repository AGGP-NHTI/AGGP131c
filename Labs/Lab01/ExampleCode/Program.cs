using System;

namespace ConsoleApp1
{
    class Program
    {
        static BaseExample b;
        static void Main(string[] args)
        {
            b = new NiceExample("What's Up doc?");
            b.YellMessage();
            b.Pause();
        }

    }

    public class BaseExample
    {

        public string Message = "123456";
        public BaseExample()
        {

        }

        public BaseExample(string s)
        {
            Message = s;
        }

        public virtual void SayMessage()
        {
            Console.WriteLine(Message);
        }

        public void YellMessage()
        {
            Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
            SayMessage(); 
            Console.WriteLine("BBBBBBBBBBBBBBBBBBBBBBBBB");
        }

        public virtual void Pause()
        {
            Console.WriteLine("\nPress Any Key");
            Console.ReadKey();
        }
    }

    public class ChildExample : BaseExample
    {

        string otherstring = "This is some other string"; 
        public ChildExample() :base()
        {
            Message = "654321"; 
        }

        public ChildExample(string s): base(s)
        {
            
        }

        public override void SayMessage()
        {
            
            Console.WriteLine(otherstring);
            base.SayMessage();
        }


    }

    public class RudeExample : ChildExample
    {

        public RudeExample(string s) : base(s)
        {

        }
        public override void Pause()
        {
            Console.WriteLine("\nYo, Press a Key Already... Punk.");
            Console.ReadKey();
        }
    }


    public class NiceExample : ChildExample
    {

        public NiceExample(string s) : base(s)
        {

        }
        public override void Pause()
        {
            Console.WriteLine("\nWill You Please Press a Key.");
            Console.ReadKey();
        }
    }

}
