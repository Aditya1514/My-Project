using System;

namespace CodeCheff1
{
   
    class Program
    {
         public static void Main()
        {
            int Number1, Number2, result;
            Console.WriteLine("Enter Number1");
           Number1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number2");
            Number2 = Convert.ToInt32(Console.ReadLine());

          result = Number1 + Number2;
            Console.WriteLine("{0} + {1}  = {2}",Number1,Number2,result);
        }

    }
}
