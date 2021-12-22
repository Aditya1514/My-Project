using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring a variable by datatype
            // var number = 14;
            //  var count = 15;
            // var totalPrice = 20.85f;
            // var character = 'A';
            //  var firstName = "keer";
            // var isWorking = false;

            // Console.WriteLine(number);
            //Console.WriteLine(count);
            // Console.WriteLine(totalPrice);
            // Console.WriteLine(character);
            // Console.WriteLine(firstName);
            // Console.WriteLine(isWorking);

            //Variables Dataype
            // Console.WriteLine("{0} {1}",byte.MinValue,byte.MaxValue);
            // Console.WriteLine("{0},{1}",float.MinValue,float.MaxValue);
            // Console.WriteLine("{0},{1}",int.MinValue,int.MaxValue);

            //Constants
            //const float pi = 3.14f;
            // Console.WriteLine(pi);

            //Type Conversion in Implicit
            // byte b = 1;
            // int i = b;
            //Console.WriteLine(i);

            //In Explicit or casting
            //int i = 1;
            // byte b = (byte) i;
            // Console.WriteLine(b);

            //Non Compatible type
            //var number = "1514";
            // int i = Convert.ToInt32(number);
            // Console.WriteLine(i);

            //Dealing with execption using try and catch
            // try
            //{
            //  var number = "1514";
            // byte b = Convert.ToByte(number);
            //  Console.WriteLine(b);
            // }
            // catch (Exception)
            // {
            //Console.WriteLine("the given number does not stored in byte");
            //}

            //Operators

            var a = 15;
            var b = 14;
            Console.WriteLine((float) a/(float) b);

        }
    }
}
