using System;

namespace CSharp6
{
    class Program
    {
        public static void Main()
        {
            Program p = new Program();
            p.evenNumbers();

            Program P = new Program();
            int Sum = P.Add(15, 14);
            Console.WriteLine("Sum = {0}", Sum);
        }
        public int Add(int FN, int SN)
        {
            return FN + SN;

        }
        public void evenNumbers()
        {
            int start = 0;
            while (start <= 20)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }
    }
}

