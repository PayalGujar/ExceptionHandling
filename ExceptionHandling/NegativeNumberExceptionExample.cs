using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class NegativeNumberException:Exception
    {
        public NegativeNumberException(string error):base(error)  
        { }
    }

    public class user
    {
        public user(int num)
        {
            if(num<0)
            {
                throw new NegativeNumberException("Number is Negative:Invalid");
            }
        }
        
    }
    public class program1
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Number");
                int num = Convert.ToInt32(Console.ReadLine());
                user u = new user(num);
            }
            catch(NegativeNumberException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
