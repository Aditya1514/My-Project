using System;
//Basics to interfaces
namespace Csharpp9
{
    interface ICustomer
    {
        void print1();
    }
    interface I1514 : ICustomer
    {
        void print2();
    }
    public  class Customer : ICustomer
    {
        public void print1()
        {
            Console.WriteLine("Interface print Method");
        }
       public void print2()
        {
            Console.WriteLine("I1514 method");
        }
    }
    class Program
    {
        static void Main()
        {
            Customer C1 = new Customer();
            C1.print1();
            C1.print2();
           /* Customer C2 = new Customer();
            C2.print1();*/


        }
    }
}
