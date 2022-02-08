using System;
using System.Collections.Generic;

namespace Codecheff8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> answers = new List<int>();
            int ARange = Convert.ToInt32(Console.ReadLine());
            int InputRange = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<ARange;i++)
            {
                string K = Console.ReadLine();
                string[] inputval = K.Split(' ');
                int[] Values = new int[inputval.Length];
                for (int j =0; j<inputval.Length; j++)
                {
                    Values[j] += Convert.ToInt32(inputval[j]);
                }
                Array.Sort(Values);
                answers.Add(Values[0] + Values[1]);
            }
            foreach (var item in answers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
