using System;
//Structures in C#
namespace Csharpp8
{
    public struct Customer
    {
        private int _id;
        private string _Name;

        public int id
        {
            get { return this._id; }
            set { this._id = value; }

        }
        public string Name
        {
            get { return this._Name; }
            set { this._Name = value; }

        }
        public Customer(int id, string Name)
        {
            this._id = id;
            this._Name = Name;
        }

        public void printDetails()
        {
            Console.WriteLine("id ={0},Name={1}", _id, _Name);
        }
    }
        class Program
    {
        static void Main()
        {
            Customer C1 = new Customer();
            C1.id = 101;
            C1.Name = "Aditya";
            C1.printDetails();

            Customer C2 = new Customer(102, "keer");
            C2.printDetails();

            Customer C3 = new Customer(103, "AKS");
            C3.printDetails();

        }
    }
}
