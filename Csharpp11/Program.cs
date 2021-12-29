using System;
//Abstract Class
namespace Csharpp11
{
   public abstract class employee
    {
        public void Print()
        {
            Console.WriteLine("Emp Name is Badshah");
        }
        
    }
   public  class Program : employee
    {
        
       public static void Main()
        {
            employee P = new Program();
            P.Print();

        }
    }
}
