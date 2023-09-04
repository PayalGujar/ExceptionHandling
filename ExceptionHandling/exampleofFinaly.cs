using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
1.Show the use of finlly block
Chcek the  code try with finally
2.WAP to show try with MultiCatch .
3.WAP to show Error in code which is not handled
 */

namespace ExceptionHandling
{

    class NumberChecking
    {
        public int number;

        public NumberChecking(int  number)
        {
            this.number = number;
        }
        public int divide(int divisor)
        {
            return this.number / divisor;
        }
        public string Display()
        {
            return $"{number} Entered";
        }

    }
    internal class exampleofFinaly
    {
        public static void Main(string[] args)
        {
            try
            {
               
                Console.WriteLine("Enter Number(Must be non Negative)");
                int num = Convert.ToInt32(Console.ReadLine()); 
                if (num < 0)
                {
                    throw new NegativeNumberException("Number Is negative");
                }
                Console.WriteLine("Enter Divisor(Non zero Value)");
                int div= Convert.ToInt32(Console.ReadLine());
                NumberChecking nc = new NumberChecking(num);
                if(div == 0) 
                {
                    throw new DivideByZeroException("Cannot divide by zero");
                }
                Console.WriteLine(nc.Display());
                Console.WriteLine(nc.divide(div));
            }
            catch (NegativeNumberException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("File Submitted");
            }
        }
    }
}
