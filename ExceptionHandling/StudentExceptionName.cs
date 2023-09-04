using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class NameException:Exception
    {
        public NameException(string error):base(error) 
        { 
        }
    }
    public class Student
    {
        public Student(string name)
        {
            name = null;
            if(string.IsNullOrEmpty(name))
            {
                throw new NameException("Name is invalid");
            }
        }
    }
    public class StudentExceptionName
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();
                Student st = new Student(name);
            }
            catch (NameException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
