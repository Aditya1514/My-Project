using System;
//Explicit Interface Implementation
namespace Csharpp10
{
    interface I1Student
    {
        void ExpMethod1();
    }
    interface I2Student
    {
        void ExpMethod2();
    }
    public class Program : I1Student, I2Student
    {
        void I1Student.ExpMethod1()
        {
            Console.WriteLine("Aditya Keer");
        }
        void I2Student.ExpMethod2()
        {
            Console.WriteLine("AKS 1415");
        }
       public static void Main()
        {
            Program P = new Program();
            ((I1Student)P).ExpMethod1();
            ((I2Student)P).ExpMethod2();

        }
    }

   
} 

