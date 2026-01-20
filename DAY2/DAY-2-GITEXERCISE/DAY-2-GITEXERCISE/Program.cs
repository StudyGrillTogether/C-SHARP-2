using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace DAY_2_GITEXERCISE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your first name ");
            string fname=Console.ReadLine();
            Console.WriteLine("enter your middle name ");
            string mname=Console.ReadLine() ;
            Console.WriteLine("enter your last name");
            string lname=Console.ReadLine() ;
            string Name = fname + mname + lname;
            Console.WriteLine($"your name is {Name}");
            Console.WriteLine("enter your death of birth");
            DateTime dob; //creates an empty datetime box and will be filled only if conversion works
            if(DateTime.TryParse(Console.ReadLine(),out dob))
            {
                Console.WriteLine("birth year:" + dob.Year);
                
            }
            else
            {

                Console.WriteLine("invalid date");
               
            }
            DateTime now = DateTime.Now;
            int age = now.Year - dob.Year;
            if (dob.Date > now.AddYears(-age))
            {
                age--;
            }
            Console.WriteLine($"the age of the person is {age}");
            Console.WriteLine($" the initial is {fname} the birth year is {dob.Year} THE age is {age}");

        }
    }
}
