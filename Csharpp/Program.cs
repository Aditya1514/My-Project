using System;
  // Printing FirstName,LastName of employee using classes

namespace Csharpp
{
    class Employee
    {
        string _firstName;
        string _lastName;
        int _dob;

        public Employee(string FirstName, string LastName, int DOB)
        {
            _firstName = FirstName;
            _lastName = LastName;
            _dob = DOB;

        }
        public void PrintFullName()
        {
            Console.WriteLine("FullName = {0}", _firstName +""+ _lastName+""+_dob);
        }
        ~Employee()
        {
            //Cleanup code goes here
        }
    }
    class Program
    {
        public static void Main()
        {
            Employee E15 = new Employee("Aditya","Keer",15-4-21);
            E15.PrintFullName();
            Employee E14 = new Employee("Sir", "Khan",14-6-21);
            E14.PrintFullName();
        }
    }


    
    
}
