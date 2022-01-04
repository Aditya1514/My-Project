using System;

namespace Csharpp_class_with_a_Method
{
    class Student
    {
        private int _Id;
        private string _Name;
        private string _email;

        public int Id
        {
            get { return this._Id; }
            set {
                this._Id = value;
            }
        }
        public string Name
        {
            get { return this._Name; }
            set { this._Name = value; }
        }
        public string email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        public void PrintData()
        {
            Console.WriteLine("Id is{0},Name is {1},email {2}",
                Id,Name,email);
        }
    }
    class Program
    {
        static void Main()
        {
            Student S = new Student();
            S.Id = -101;
            S.Name = "Aditya";
            S.email = "dicnondpwnecp@gmail.com";
            S.PrintData();
            Student S1 = new Student();
            S1.Id = 111;
            S1.Name = "Aditi";
            S1.email = "dicefrwfrwrf@gmail.com";
            S1.PrintData();

        }
    }
}
