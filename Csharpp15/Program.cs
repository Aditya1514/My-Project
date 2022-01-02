using System;

namespace Csharpp15
{
    public class Student
    {
        private int _Id;
        private string _Name;
        private string _emailId;
        private int _Age;

        public int Id
        {
            get { return this._Id; }
            set { this._Id = value; }
        }
        public string Name
        {
            get { return this._Name; }
            set { this._Name = value; }
        }
        public string email
        {
            get { return this._emailId; }
            set { this._emailId = value; }
        }
        public int Age
        {
            get { return this._Age; }
            set { this._Age = value; }
        }
        public  Student(int RollNo, string Name, string emailId, int Age)
        {
            this._Id = RollNo;
            this._Name = Name;
            this._emailId = emailId;
            this._Age = Age;
        }
        public void PrintDetails()
        {
            Console.WriteLine("Id = {0},Name = {1},emailId = {2},Age ={3}",
                           _Id,_Name,_emailId,_Age  );
        }
    }
   public class Program
    {
       public static void Main()
        {
            Student S = new Student(1,"Add","dipncecnep@gmail.com",23);
            Student S1 = new Student(2, "sub", "euoorvh[orr@gmail.com", 21);
            Student S2 = new Student(3, "Multi", "sadfrninroor@gmail.com", 23);



            S.PrintDetails();
            S1.PrintDetails();
            S2.PrintDetails();
        }
    }
}
