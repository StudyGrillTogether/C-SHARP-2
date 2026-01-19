using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAY_1_GITEXERCISE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name");
            string Name=Console.ReadLine();
            Console.WriteLine("enter your age");
            if(!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("invalid age format");
                return;
            }
            Console.WriteLine("enter your salary");
            if(!int.TryParse(Console.ReadLine(), out int salary))
            {
                Console.WriteLine("invalid salary input");
                return;
            }
            
            

            int ageNextYear = age + 1;
            double monthlySalary = salary / 12.0;

            Console.WriteLine($"\nName: {Name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Age next year: {ageNextYear}");
            Console.WriteLine($"Annual Salary: ₹{salary}");
            Console.WriteLine($"Monthly Salary: ₹{monthlySalary:F2}");



        }
    }
}
