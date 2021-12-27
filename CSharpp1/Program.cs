using System;
//Static And Instance
namespace CSharpp1
{
    class Circle
    {
        float _pi = 3.141F;
        int _radius;
        public Circle(int Radius)
            {
               _radius = Radius;
             }
        public float PrintArea()
        {
            return _pi * _radius * _radius;
           
        }
    }
    class Program
    {
        static void Main()
        {
            Circle C15 = new Circle(5);
             float Area  =C15.PrintArea();
            Console.WriteLine("Area = {0}",Area);

            Circle C14 = new Circle(20);
            float Area1 = C14.PrintArea();
            Console.WriteLine("Area={0}",Area1);
        }
    }
}
