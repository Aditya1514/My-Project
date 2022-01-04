using System;
using System.Collections.Generic;
namespace Interfaces
{
     interface  IMovable
    {
        void Move();
    }
    class Person : IMovable
    {
        public void Move()
        {
            Console.WriteLine("I will Move by walking- Person");
        }
    }
    class Fish : IMovable
    {
        public void Move()
        {
            Console.WriteLine("I will Move by swiming - Fish");
        }
    }
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("I Move by driving -car");
        }
        
    }
    class Program
    {
        static void Main()
        {
            List <IMovable> Movable = new List<IMovable>();
            Movable.Add(new Person());
            Movable.Add(new Fish());
            Movable.Add(new Car());
            foreach(var o in  Movable)
            {
                o.Move();
            }
            
        }
    }
}
