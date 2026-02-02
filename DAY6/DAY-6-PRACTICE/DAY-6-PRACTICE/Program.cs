using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAY_6_PRACTICE
{
    internal class Program
    {
        static int multiply(int a,int b)
        {
            int result=a*b;
            return result;
            //parameters a,b
            //local variable result
        }
        static void Main(string[] args)
        {
            //1.if/elseif/else
            int marks = 72;
            if (marks > 90)
            {
                Console.WriteLine("GRADE A");
                // runs if condition is true
            }
            else if (marks>= 75)
            {
                Console.WriteLine("GRADE B");
                // runs if first condition is false AND this is true
            }
            else if(marks>=60)
            {
                Console.WriteLine("GRADE C");
                
            }
            else
            {
                Console.WriteLine("fail");
                // runs if none of the above are true
            }
            //ex -2
            int age = 20;
            bool hasID = true;

            if (age >= 18 && hasID)
            {
                Console.WriteLine("Allowed entry");
            }
            else
            {
                Console.WriteLine("Not allowed");
            }

            //2.switch statements 
            //old
            int day = 3;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                default:
                    Console.WriteLine("Invalid day");
                    break;
            }

            //new
            int marks1 = 85;

            switch (marks1)
            {
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

            //switch expression
            //exxample of nesting
            int age1 = 20;
            bool hasID1 = true;
            if (age > 18)
            {
                if (hasID)
                {
                    Console.WriteLine("entry allowed");
                }
                else
                {
                    Console.WriteLine("id required");
                }
            }
            else
            {
                Console.WriteLine("under age");
            }
           
            //this works but readinility drops as nesting grows
            //instead
            if(age1>18&& hasID1)
            {
                Console.WriteLine("allowed");
            }

            //using ref to modify cariable
            int x = 5;
            increment(ref x);
            Console.WriteLine(x);
            int x1, y1;
            getvalue(out x1, out y1);
            Console.WriteLine(x1);
            Console.WriteLine(y1);

            //example of out 
            bool success = int.TryParse("123", out int result);

            if (success)
            {
                Console.WriteLine(result); // 123
            }
            //method returns bool
            //parsed number is returned via out

            //not using big code 
            ProcessStudent(90);

            //enum with swithc
            Day today = Day.Friday;

            switch (today)
            {
                case Day.Monday:
                    Console.WriteLine("Start of work week");
                    break;

                case Day.Friday:
                    Console.WriteLine("Almost weekend");
                    break;

                case Day.Saturday:
                case Day.Sunday:
                    Console.WriteLine("Weekend!");
                    break;
            }


        }
        static void increment(ref int x)
        {
            x = x + 5;
        }
        static void getvalue(out int a,out int b)
        {
            a = 20;
            b = 20;
        }

        //creating efficient code with clean methods
        static bool isvalidMarks(int marks)
        {
            return marks >= 0 && marks <= 100;
        }
        static string CalculationGrade(int marks)
        {
            if (marks >= 90) return "A";
            if(marks>=75) return "B";
            if (marks > -60) return "C";
            return "Fail";
        }
        static void PrintResult(string grade)
        {
            Console.WriteLine("Grade:" + grade);
            Console.WriteLine(grade != "Fail" ? "Passed" : "Failed");
        }
        static void ProcessStudent(int marks)
        {
            if (!isvalidMarks(marks)){
                Console.WriteLine("invalid marks");
                return;
            }
            string grade = CalculationGrade(marks);
            PrintResult(grade);
        }
        enum Day
        {
            Monday, //internally monday=0,tuesday=1 and so on auto increment
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        

    }
}
