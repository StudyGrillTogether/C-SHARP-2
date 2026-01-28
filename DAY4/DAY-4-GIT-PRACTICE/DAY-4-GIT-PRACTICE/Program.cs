using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_4_GIT_PRACTICE
{
    internal class Program
    {
        class invalidmarksException : Exception
        {
            public invalidmarksException(string message) : base(message)
            {

            }
        }
        static void checkmarks(int marks)
        {
            if(marks<0|| marks > 100)
            {
                throw new invalidmarksException("marks must be between 0 and 100");
            }
            Console.WriteLine("marks accepted");
        }
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArgumentException("access denied -you must be at least 18");
            }
            else
            {
                Console.WriteLine("access granted- you are old enough");
            }
        }
        static void Witdraw(int balance,int amount)
        {
            if (amount > balance)
            {
                throw new InvalidOperationException("insufficient balance");
            }
            Console.WriteLine("withdar succesful");
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter your age");
                int age = Convert.ToInt32(Console.ReadLine());
                checkAge(age);
            }
            catch(FormatException)
            {
                Console.WriteLine("invalid input. please enter a number");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("soething went wrong");
            }
            //use multiple catch blocks to handle different failure scenarios separately,
            //giving specific feedback for known exceptions and a generic fallback for unexpected ones.
            Witdraw(20000, 100000);
            //task 3
            try
            {
                Console.WriteLine("ener marks:");
                int marks = Convert.ToInt32(Console.ReadLine());
            }
            catch(invalidmarksException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("enter a valid number");
            }
        }
    }
}
