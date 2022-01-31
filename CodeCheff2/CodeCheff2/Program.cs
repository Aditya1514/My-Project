using System;

namespace CodeCheff2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 412, sum = 0;
            while (number >0)
            {
                sum = sum + (number % 10);
                number = number / 10;
            }
            Console.WriteLine("Sum of digits is {0}",sum);
        }
    }
}
