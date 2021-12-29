using System;

namespace Csharpp12
{
    public delegate void HelloFromDelegate(string Message);
    class Program
    {
       public static void Main()
        {
            HelloFromDelegate del = new HelloFromDelegate(Hello);
                del("dsvldcil");
        }
        public static void Hello(string message)
        {
            Console.WriteLine(  message);
        }
    }

} 
