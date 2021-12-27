using System;
using static CSharpp2.Employee;
//Inheritance
namespace CSharpp2
{
    public class Employee
    {
        public string firstname;
        public string lastname;
        public string email;
        public void PrintFullName()
        {
            Console.WriteLine(firstname + " "+ lastname);
        }
        public class FullTimeEmployee : Employee
            {
            public float MonthlySalary;

           
        }
        public class PartTimeEmployee : Employee
        {
            public float HourlySalary;
        }
    }
    class Program
    {
       public static void Main()
        {
            FullTimeEmployee FT = new FullTimeEmployee();
            FT.firstname = "Adithya";
            FT.lastname = "Keer";
            FT.MonthlySalary = 5050000;
            FT.PrintFullName();

            PartTimeEmployee PT = new PartTimeEmployee();
            PT.firstname = "Sir";
            PT.lastname = "Keer";
            PT.HourlySalary = 1000;
            PT.PrintFullName();

        }

        
    }
}
