using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            
            try
            {
                string name = null;
                Console.WriteLine("Enter Name");
                name= Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    throw new Exception("Name is required");

                }
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine("Name is invalid"+ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }
            

        }
    }
}
