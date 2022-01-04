using System;
using System.Collections.Generic;
namespace Array_on_lists
{
      class Student
    {
        private int[] Grades;

        public Student(int[] marks)
        {
            Grades = marks;
        }
    
        public double GetAverage()
        {
            int sum = 0;
            foreach(int gr in Grades)
            {
                sum += gr;
            }
            return sum / Grades.Length;
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Your Grades:");
            List<int> Values = new List<int>();
            string s;
            int mark;
            while(true)
            {
                s = Console.ReadLine();
                if (int.TryParse(s, out mark))
                {
                    Values.Add(mark);
                }
                else if(s=="Exit")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            Student S = new Student(Values.ToArray());
            Console.WriteLine("Average Grade is" + S.GetAverage());
        }
    }
}
