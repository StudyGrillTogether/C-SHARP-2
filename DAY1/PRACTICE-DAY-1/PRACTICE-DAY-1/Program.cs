using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICE_DAY_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //implicit casting here it allows due to double has longer range than int and higher precision
        //char-int-long-float-double implicit casting ranges 
            int myint = 9;
            double myddouble = myint;
            Console.WriteLine(myint);

            //but in explicit casting this must be done manually
            double x = 9.6;
            int y = (int)x;
            Console.WriteLine(y);
            Console.WriteLine(x);
            
            //using explicit methods its possible as well

            double num1 = 4.5;
            Console.WriteLine(Convert.ToInt32(num1));

            //taking safe user input
            // safe way 
            Console.Write("Enter age: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int age))
            {
                Console.WriteLine("Invalid age input");
                return;
            }


            //compare numeric types
            int a = 10;
            int b = 20;
            Console.WriteLine(a<b);

            double a1 = 0.1 + 0.2;
            double b1 = 0.3;
            Console.WriteLine(a1== b1); 
            //o/p false since floating point numbers are not stored exactly in memory
            //safe way
            Console.WriteLine(Math.Abs(a1 - b1)<0.0001);

            int i = 10;
            double d = 10.5;
            Console.WriteLine(i<d);

        }
    }
}
