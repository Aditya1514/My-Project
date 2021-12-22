using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //if statement in C#
            /*Console.Write("Enter Your Number");
            int UserNumber = int.Parse(Console.ReadLine());
           if (UserNumber == 1514)
            {
              Console.WriteLine("Your Number is One Five One four");
            }
            if (UserNumber == 1415)
            {
                Console.WriteLine("Your Number is One Four One Five");
            }
            if (UserNumber ==2)
            {
                Console.WriteLine("Your NUmber is Two");
            }
            else 
            {
                Console.WriteLine("Please enter a valid number");
            }*/

            //Switch Statement in C#
            /* Console.WriteLine("Your Name Is");
             var Name = Console.ReadLine();
             switch(Name)    
             {
                 case "Aditya":
                 Console.WriteLine("Your Name Is Aditya" );
                     break;
                 case "Keer":
                     Console.WriteLine("Your Name Is Keer");
                     break;
                 case "siad":
                     Console.WriteLine("Your Name Is siad");
                     break;
                 default:
                     Console.WriteLine("Enter a Valid Name");
                     break;

             }*/
            //Switch Eg-2 Shopping a ??
            var TotalCost = 0;

        Start:
            Console.WriteLine("1 -Small, 2 -Large, 3 -ExtraLarge");
            var UserChoice = int.Parse(Console.ReadLine());
            switch (UserChoice)
            {
                case 1:
                    Console.WriteLine("You Ordered a Small");
                    TotalCost += 100;
                    break;
                case 2:
                    Console.WriteLine("You Ordered a Large");
                    TotalCost += 150;
                    break;
                case 3:
                    Console.WriteLine("You Ordered a ExtraLarge");
                    TotalCost += 220;
                    break;
                default:
                    Console.WriteLine("Enter a Valid Order", UserChoice);
                    
                    goto Start;
            }
        
            Decide:
            Console.WriteLine("Do you want to buy some more -Yes or No?");
            var UserDecision = (Console.ReadLine());
              switch(UserDecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Enter a valid decision",UserDecision);
                    goto Decide;

            }
            Console.WriteLine("ThankYou for Ordering ");
            Console.WriteLine(" Your Total Bill Amount is ={0}",TotalCost);


        }
    }
}
