using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 10.WAP to check number is binary or not if not then throw Exception 
else convert into decimal.
 */

namespace ExceptionHandling
{
    class BinaryCheckException:Exception
    {
        public BinaryCheckException(string error):base(error)  
        { }
    }
    public class BinaryCheck
    {
       public static void Main(string[] args)
        {
            try
            {
                string binarystring = "";
                Console.WriteLine("Enter Binary Number");
                string bstring=Console.ReadLine();
                char[] chstring= bstring.ToCharArray();
                for(int i = 0; i < chstring.Length; i++)
                {
                    if (chstring[i] =='0' || chstring[i] == '1')
                    {
                        binarystring += chstring[i];
                    }
                    else
                    {
                        throw new BinaryCheckException("String Contains non Binary Value");
                    }
                }
                int decimalNumber = Convert.ToInt32(binarystring, 2);
                Console.WriteLine(decimalNumber);
            }
            catch(BinaryCheckException e) 
            { 
                Console.WriteLine(e.Message);
            }
        }
       
    }
}
