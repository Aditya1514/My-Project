using System;
using System.Collections.Generic;
namespace polymorphism
{
    class computerDevice
    {
        private string name;
        private string Address;

        public computerDevice(string N,string s)
        {
            name = N;
            Address = s;
        }
       
        
        public virtual void Input()
        {
            Console.WriteLine("Basic Configuring Message...");
        }

    }

    class Laptop : computerDevice
    {
        private string Mouse;

        public Laptop(string M) : base(N, s)
        {
            Mouse = M;
        }

        public static string N { get; }
        public static string s { get; }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Configuring Laptop.");
        }

    }
    class Tablet : computerDevice
    {
        private string Device;
         
        public Tablet ( string v) : base (N,s)
        {
            Device = v;
        }
        public static string N { get; }
        public static string s { get; }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Configuring Tablet..");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<computerDevice> myList = new List<computerDevice>();
            myList.Add(new Tablet("my Tablet"));
            myList.Add(new Laptop("my Laptop"));
            foreach(computerDevice cd in myList)
            {
                cd.Input();
            }

        }
    }
}
