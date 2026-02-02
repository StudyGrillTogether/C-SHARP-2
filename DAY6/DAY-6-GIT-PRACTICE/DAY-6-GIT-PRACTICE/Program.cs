using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_6_GIT_PRACTICE
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter your marks");
            int marks1 = Convert.ToInt32(Console.ReadLine());

            switch (marks1)
            {
                case int m when m < 0 || m > 100:
                    Console.WriteLine("invalid marks");
                    break;
                case int m when m >= 90:
                    Console.WriteLine("Grade A");
                    break;

                case int m when m >= 75:
                    Console.WriteLine("Grade B");
                    break;

                case int m when m >= 60:
                    Console.WriteLine("Grade C");
                    break;

                default:
                    Console.WriteLine("Fail");
                    break;
            }

        }
    }
}
