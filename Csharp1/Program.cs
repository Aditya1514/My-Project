using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reading and writing to Console
            // Console.WriteLine("Enter Your FirstName");

            // var FirstName = Console.ReadLine();

            // Console.WriteLine("Enter Your LastName");

            // var LastName = Console.ReadLine();

            //Console.WriteLine("HAI {0}{1}", FirstName, LastName);

            //Escape sequences
            // var Name = "one\nTwo\nThree";
            // Console.WriteLine(Name);

            //Arrays in C#
            /* string[] Names = new string[3];
             Names[0] = "Aditya";
             Names[1] = "keer";
             Names[2] = "Virat";

             Console.WriteLine(Names[1]);*/
            Console.WriteLine("Enter your Name");

            int i = int.Parse(Console.ReadLine());
            Console.WriteLine(i);
        }
    }
}
