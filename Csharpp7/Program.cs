using System;
//read/write properties using get,set
namespace Csharpp7
{
    public class Student
    {
        private int _id;
        private string _Name;
        private int _passMark=35;
        public int id
            {
            set
            {
                if(id<0)
                {
                    throw new Exception("Id Should not to be negative");
                }
                this._id = value;
            } 
           
            get
            {
                return this._id;
            }
            }
          public string Name
        {
            set
            {
                if
                (string.IsNullOrEmpty(value))
                {
                    throw 
                }
                   
            }
        }
        
        
        public void SetPassMark(int PassMark)
        {
            if (PassMark < 35)
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


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); 
        }
    }
}
