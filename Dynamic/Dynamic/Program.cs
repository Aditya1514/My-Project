using System;

namespace Dynamic
{
    public class dynamicCalc
    {
        public dynamic Add (dynamic x, dynamic y)
        {
            return x + y;
        }
        public dynamic Divide (dynamic x , dynamic y)
        {
            return y!=0 ? x / y : 0;
        }
        public dynamic sub (dynamic x, dynamic y)
        {
            return x - y;
        }
    }
    class Program
    {
        static void Main()
        {
            dynamicCalc myCalc = new dynamicCalc();
            Console.WriteLine("Sum is ",myCalc.Add(15,14));
            Console.WriteLine("Ratio is", myCalc.Divide(58978555,58794569.78));
            Console.WriteLine("Difference is",myCalc.sub(15,14));
        }
    }
}
