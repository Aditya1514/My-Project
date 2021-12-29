using System;
//Diff b/w MethodOverriding And Method Hiding 
//the only diff we have to add new keyword for hiding
namespace ConsoleApp2
{
    public  class BaseClass
    {
        public  virtual void print()
        {
            Console.WriteLine("Im a BaseClass Print Method");
        }
        
    }
    public class DerivedClass : BaseClass
    {
        public override void print()
        {
            Console.WriteLine("Im a DerivedClass Print Method");
        }
    }

    class Program
    {
        static void Main()
        {
            BaseClass B = new DerivedClass();
            B.print();
        }
    }
}
