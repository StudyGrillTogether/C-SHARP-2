using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_4_PRACTICE
{
   
    internal class Program
    {
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("access denied -you must be at least 18");
            }
            else
            {
                Console.WriteLine("access granted- you are old enough");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[10]);


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // another way if you want your own message
            try
            {
                int[] mynumbers = { 1, 2, 3 };
                Console.WriteLine(mynumbers[10]);
            }
            catch(Exception e)
            {
                Console.WriteLine("something went wrong");
            }
            finally
            {
                Console.WriteLine("the try catch is finished");
            }
            //using throw new exceptions
            checkAge(15);
            

        }
    }
}
