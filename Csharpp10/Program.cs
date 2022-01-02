using System;
//Explicit Interface Implementation
namespace Csharpp10
{
  interface IEmployee
    {
        void ExpMethod1();
    }
  interface IEmployee1
    {
        void ExpMethod2();
    }
    
  public class Program : IEmployee,IEmployee1
    {
        void IEmployee.ExpMethod1()
        {
            Console.WriteLine("Badshah");
        }

        void IEmployee1.ExpMethod2()
        {
            Console.WriteLine("Shershah");
        }
        public static void Main()
        {
            Program P = new Program();
            ((IEmployee)P).ExpMethod1();
            ((IEmployee1)P).ExpMethod2();
        }
    }
} 

