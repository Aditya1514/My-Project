using System;

namespace Codecheff3
{
    class Program
    {
        static void Main()
        {
            int number = 123;
            int remainder;

            while (number > 0)
            {
                remainder = number % 10;
                Console.WriteLine("{0}",remainder);
                number = number / 10;
            }

        }
    }
}
