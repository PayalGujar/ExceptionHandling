using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 2.WAP to check String content only alphabets if any digit or symbol is present then throw custom exception
 */

namespace ExceptionHandling
{
    class AlphabetException:Exception
    {
        public AlphabetException(string message) : base(message)
        {

        }
    }

    class User
    {
        public User(string name) 
        {
            for(int i=0;i<name.Length; i++)
            {
                if (name[i] >='A' && name[i] <='Z' || name[i] >= 'a' && name[i] <= 'z')
                {
                    continue;
                }
                else
                {
                    throw new AlphabetException("String contains digits & Symbols:Code terminate");
                }
            }
            
        }
    }

    public class AlphabetError
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter String");
                string str = Console.ReadLine();
                User u = new User(str);
            }
            catch (AlphabetException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}






