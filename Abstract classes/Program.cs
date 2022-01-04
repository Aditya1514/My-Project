using System;

namespace Abstract_classes
{
     abstract class ThreeDshape
    {
    }
    class Sphere : ThreeDshape
    {
        private double radius;

        public Sphere (double r)
        {
           this.radius  = r;
        }
        public  double GetVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }
    }
    
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Volume of Sphere :"+Math.Round(new Sphere (5).GetVolume(),2));
        }
    }
}
