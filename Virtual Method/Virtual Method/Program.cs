using System;

namespace Virtual_Method
{
    public class Product
    {
        private int price;

        public Product(int a)
        {
            price = a;
        }
        public  virtual string Getdesc()
        {
            return "price :" + price;
        }
    }
    public class Book : Product
    {
        private string title;

        public Book(string s,int a) : base(a)
        {
            title = s;
        }
        public override string Getdesc()
        {
            return base.Getdesc()+"\nTitle :" +title;
        }

    }
   public class Program
    {
        static void Main()
        {
            Book B = new Book("Bahubali The Conclusion", 2500);
            Console.WriteLine(B.Getdesc());
        }
    }
}
