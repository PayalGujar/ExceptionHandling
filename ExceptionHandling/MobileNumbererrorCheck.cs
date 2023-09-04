using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
5.WAP to take mobile number  in String from user 
a)if it is content number of digit less than 10 or more than 10
then throw Exception.
b)If String content any alphabet or symbol then thorw InvalidMobileException.
 */

namespace ExceptionHandling
{
    class MobileNumberException:Exception
    {
        public MobileNumberException(string Error):base(Error)  
        { }
    }

    public class UserNumber
    {
        public string num;
        public UserNumber(string num)
        {
            this.num = num;
        }
    }
    public class MobileNumbererrorCheck
    {
        public static void Main(string[] args)
        {
            try 
            {
                int cnt = 0;
                Console.WriteLine("Enter Mobile Number");
                string MobileNumber = Console.ReadLine();
                char[] ch = MobileNumber.ToCharArray();
                for (int i = 0; i < ch.Length; i++)
                {
                    cnt++;

                }
                if(cnt >10)
                {
                    throw new MobileNumberException("Number Is Invalid :More than 10");
                }
                if(cnt < 10)
                {
                    throw new MobileNumberException("Number Is Invalid:Less than 10");
                }

            }
            catch(MobileNumberException e)
            {
                Console.WriteLine(e.Message);
            }
            

        }

    }
}
