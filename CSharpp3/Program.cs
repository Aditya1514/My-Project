using System;
using static CSharpp3.Employee;
//Method hiding
namespace CSharpp3
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        public void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
        public class fullTimeeemployee : Employee
        {
        }
        
        public class partTimeemployee : Employee
        {
            public new void printFullName()
            {
                Console.WriteLine(firstName + " " + lastName + "-Contractor"    );
            }
        }

}
    class Program
    {
      public static void Main ()
        {
            fullTimeeemployee F15 = new fullTimeeemployee();
            F15.firstName = "Aditya";
            F15.lastName = "Keer";
            F15.printFullName();

            Employee P14 = new partTimeemployee();
            P14.firstName = "Siri";
            P14.lastName = "Adi";
            P14.printFullName();


        }
    }
}
