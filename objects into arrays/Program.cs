using System;

namespace objects_into_arrays
{
    class Student
    {
        private int[] Grades = { 98, 98, 83, 83 ,93};

        public int this[int index]
        {
            get { return Grades[index]; }
            set { Grades[index] = value; }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student S = new Student();
            S[2] = 81;
            for (int i=0; i < 5; i++)
            {
                Console.WriteLine("Grade is : {0}",S[i]);
            }
        }
    }
}
