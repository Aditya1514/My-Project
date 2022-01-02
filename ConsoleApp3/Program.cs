using System;

namespace ConsoleApp3
{
    interface IEmployee
    {
        void interfaceMethod1();
    }
    interface IEmployee1
    {
        void interfaceMethod2();
    }
    public class Employee : IEmployee, IEmployee1

    {
        void IEmployee.interfaceMethod1()
        {
            Console.WriteLine("EMployee Name is Badshah");
        }
        void IEmployee1.interfaceMethod2()
        {
            Console.WriteLine("Employee Name is Shershah");
        }
    }
   public class Program
    {
      public  static void Main()
        {
            Program P = new Program();
            ((IEmployee)P).interfaceMethod1();
            ((IEmployee1)P).interfaceMethod2();
        }
    }
}
