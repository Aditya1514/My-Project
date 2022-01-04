using System;
namespace Csharppp1
{
    class Employee121
    {
        string _firstName;
        string _secondName;
       


            public void PrintData()
            {
                Console.WriteLine("Name is {0}", _firstName + "" + _secondName
                   );

            }




            class Program
            {


                public static void Main()
                {
                    Employee121 del = new Employee121();
                    del._firstName = "Aditya";
                    del._secondName = "keer";
                    del.PrintData();

                }
            }

        }
    }

  
       
    
    

