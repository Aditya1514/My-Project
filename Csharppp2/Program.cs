using System;
//class
namespace Csharppp2
{
    class Subject
    {
        
        private string name;
        private int Id;
        public Subject( string n, int a )
        {

            name = n;
            Id = a;
                
        }
        public void Sata()
        {
            Console.WriteLine("I'm {0},Id is{1}",  name,   Id);
        }
    }
    
         
    class Program
    {
        static void Main()
        {
            Subject s = new Subject("Aditya",101);
            s.Sata();
            Subject s1 = new Subject("BOb",102);
            s1.Sata();

          
        }
    }
}
