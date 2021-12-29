using System;
//properties Set and get introduction
namespace CSharpp6
{
   public class Student
    {
        private int _id;
        private string _Name;
        private int _passMark;
       public void SetId(int ID)
        {
            if (_id <= 0)
            {
               // throw new Exception("Student Id cannot be negative");
            }
            this._id = ID;
        }
        public int GetID()
        {
            return this._id;
        }
        public void SetName(string Name)
        {
            if(string.IsNullOrEmpty(Name))
            {
                //throw new Exception("Name shoud not be null");
            }
            this._Name = Name;   
        }
        public string GetName()
        {
            if(string.IsNullOrEmpty(this._Name))
            {
                return "No Name";
            }
            else
            {
                return this._Name;
            }
        }
        public void SetPassMark(int PassMark)
        {
            if(PassMark<35)
            {
                //throw new Exception("PassMark should be greater than 35");
            }
            this._passMark = PassMark;
        } 
        public int GetPassMark()
        {
            return this._passMark;
        }
    }
    public class Program
    {
       public  static void Main()
        {
            Student C1 = new Student();
            C1.SetId(101);
            C1.SetName("Aditya Keer");
            C1.SetPassMark(98);
            Console.WriteLine("Student_id ={0},Student_Name ={1},Student_PassMark={2}",
                C1.GetID(),
                C1.GetName(),
                C1.GetPassMark()
                );
        }
      

    }
    
}
