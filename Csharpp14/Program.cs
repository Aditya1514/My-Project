using System;
//Enums
namespace Csharpp14
{
    public struct Employee
    {
        private int _Id;
        private string _Name;
        private int _Age;


        public int Id
        {
            get { return this._Id; }
            set { this._Id = value; }
        }
        public string Name
        {
            get { return this._Name = Name; }
            set { this._Name = value; }
        }
        public int Age
        {
            get { return this._Age = Age; }
            set { this._Age = value; }
        }
        public Employee(int Id, string Name, int Age)
        {
            this._Id = Id;
            this._Name = Name;
            this._Age = Age;
        }
        public void printDetails()
        {
            Console.WriteLine("Id ={ 0},Name={1},Age={2}",_Id,_Name,_Age);
        }

    }
     
   public class Program
    {
        public static void Main ()
        {
            Employee E = new Employee();
            E.Id = 101;
            E.Name = "Aditya";
            E.Age = 23;
            E.printDetails();

        }
     
    }

    
}
