using System;
using System.Collections.Generic;
namespace GenericClass
{
    /*class GenericNumber<T>
   // {
    //    public T Name1; public T Name2;

        public GenericNumber(T val1, T val2)
        {
            this.Name1 = val1;
            this.Name2= val2;
        }
       
    }
    class Program
    {
        static void Main()
        {
            GenericNumber<string> Gen = new GenericNumber<string>("Aditya","Kerthi");
         
            Console.WriteLine("Name1 is\n"+ Gen.Name1);
            Console.WriteLine("Name2 is\n"+ Gen.Name2);
            
        }
    }*/

    class program
    {
        static void Roman( string P)

        { Console.WriteLine(P.ToUpper()); }

        static void Main()
        {
            List<string> ns = new List<string>();
            string s = Console.ReadLine();
            while(s!= "Exit")
            {
                ns.Add(s);
                s.Console.ReadLine();
            }
            ns.ForEach(Roman);
        }
    }
}
