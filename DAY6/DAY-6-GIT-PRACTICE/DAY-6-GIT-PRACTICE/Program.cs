using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_6_GIT_PRACTICE
{
    internal class Program
    {
        static bool IsvalidMarks(int marks)
        {
            return marks >= 0 && marks <= 100;
        }
        static string CalculationGrade(int marks)
        {
            if (marks >= 90) return "A";
            if (marks >= 75) return "B";
            if (marks >= 60) return "C";
            return "Fail";
        }
        static void PrintResult(string grade)
        {
            Console.WriteLine("Grade:" + grade);
            Console.WriteLine(grade != "Fail" ? "Passed" : "Failed");
        }
        static void ProcessStudent(int marks)
        {
            if (!IsvalidMarks(marks))
            {
                Console.WriteLine("invalid marks");
                return;
            }
            string grade = CalculationGrade(marks);
            PrintResult(grade);
        }

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
            Console.WriteLine("enter your marks");
            int marks=Convert.ToInt32(Console.ReadLine());
            ProcessStudent(marks);

        }
    }
}
