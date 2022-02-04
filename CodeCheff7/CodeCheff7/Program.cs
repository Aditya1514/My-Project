using System;

namespace CodeCheff7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, div, rem;

            Console.WriteLine("Enter a Number :");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Divisor Number :");

            div = Convert.ToInt32(Console.ReadLine());
            if(num>div)
            {
                while(num>=div)
                {
                    num = num - div;
                }
                rem = num;
                Console.WriteLine("Remainder is {0}" ,rem);
            }
            else {
                Console.WriteLine("Enter a Valid Input");
            }
        }
    }
}
