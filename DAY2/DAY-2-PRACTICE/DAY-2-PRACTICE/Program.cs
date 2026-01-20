using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_2_PRACTICE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = "dharma";
            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());

            string input = "  hello world  ";
            Console.WriteLine(input.Trim());
            Console.WriteLine(input.TrimStart());
            Console.WriteLine(input.TrimEnd());

            string a = "Admin";
            string b = "admin";
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.Equals(b,StringComparison.OrdinalIgnoreCase));//true

            string email = "ks@gmail.com";
            Console.WriteLine(email.Contains("@"));
            Console.WriteLine(email.EndsWith(".com"));
            Console.WriteLine(email.IndexOf(".com"));
            Console.WriteLine(email.Substring(0,5));
            Console.WriteLine(email.Replace(".com",".net"));

            string data = "c#,Java,Python";
            string[] languages = data.Split(','); //, is sperator or delimiter
            foreach (string language in languages)
            {
                Console.WriteLine(language);
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append(" World");
            Console.WriteLine(sb.ToString());

            DateTime now=DateTime.Now;
            Console.WriteLine(now);//  system clock changes over time

            DateTime exam = new DateTime(2026, 3, 10, 9, 30, 0);
            Console.WriteLine(exam.ToString()); //manually defined

            //adding or subtracting time

            DateTime tomorrow = now.AddDays(1);
            DateTime nextWeek = now.AddDays(7);
            DateTime after2Hours = now.AddHours(2);
            DateTime lastMonth = now.AddMonths(-1);
            Console.WriteLine(nextWeek); /// and  so on

            //finding difference betwenn dates

            DateTime start = new DateTime(2026, 1, 1);
            DateTime end = DateTime.Now;
            TimeSpan diff = end - start;
            Console.WriteLine(diff.Days);
            Console.WriteLine(diff.Hours);

            //task 1 split names
            string Name = "kshitij kishor wankar";
            string[] Names = Name.Split(' '); //, is sperator or delimiter
            foreach (string var in Names)
            {
                Console.WriteLine(var);
            }


            //task 2 calculating age

            DateTime birthDate = new DateTime(2004, 11, 25);
            DateTime TODAY = DateTime.Today;
            
            int age=TODAY.Year-birthDate.Year;
            if (birthDate.Date > TODAY.AddYears(-age))
            {
                age--;
            }
            Console.WriteLine($"the age of you is : {age}");

            //task-3 formating dates

            Console.WriteLine(exam.ToString("dddd"));
            Console.WriteLine(exam.ToString("ssss"));
            Console.WriteLine(exam.ToString("dd-MMMM yyyy"));

           

            


        }
    }
}
