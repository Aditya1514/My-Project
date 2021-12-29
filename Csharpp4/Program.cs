using System;
using static Csharpp4.Employee;
//Polymorphism
namespace Csharpp4
{
    public class Employee
    {
        public string firstName ="Aditya";
        public string lastName = "Keer" ;

        public virtual void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
        public class FullTimeEmployee : Employee
        {
            public override void PrintFullName()
            {
                
                Console.WriteLine(firstName + " " + lastName + "- FullTime");
            }
        }
        public class PartTimeEmployee : Employee
        {
            public override void PrintFullName()
            {
              
                Console.WriteLine(firstName + " " + lastName + "- PartTime");
            }
        }
        public class TemporaryEmployee : Employee 
        {
            public override  void PrintFullName()
            {
               
                Console.WriteLine(firstName+ " "+lastName + " -Temporary");
            }

        }



    } 
    class Program
    {
        static void Main()
        {
            Employee[] Employee = new Employee[4];
            Employee[0] = new Employee();
            Employee[1] = new FullTimeEmployee();
            Employee[2] = new PartTimeEmployee();
            Employee[3] = new TemporaryEmployee();
           
            foreach(Employee e in Employee)
            {
                e.PrintFullName();
            }

        }
    }
}
