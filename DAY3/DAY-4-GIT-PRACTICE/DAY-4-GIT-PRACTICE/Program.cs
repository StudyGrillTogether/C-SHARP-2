using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_4_GIT_PRACTICE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //aggregates with arrays/lists
            int[] marks = { 10, 80, 90 };
            int sum = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                sum=sum+marks[i];
            }
            Console.WriteLine(sum);

            //to find maximum
            int max = marks[0];
            for(int i = 1; i < marks.Length; i++)
            {
                if (marks[i] > max)
                {
                    max = marks[i];
                }
            }
            Console.WriteLine("maximum number in the list or array is" + max);

            ///counting avearage in hashset
            HashSet<int> numbers= new HashSet<int>() { 10,20,30,40,50};
            int count=numbers.Count;//count =5
            double sums = 0;
            foreach(int n in numbers)
            {
                sums = sums + n;
            }
            double average = (double)sums / count;
            Console.WriteLine("Average = " + average);
            // counting numbers
            Queue<int> numbers1 = new Queue<int>();
            numbers1.Enqueue(10);
            numbers1.Enqueue(20);
            numbers1.Enqueue(30);
            numbers1.Enqueue(40);
            
            int coun1t= numbers1.Count;
            Console.WriteLine((coun1t));
            //another way to do this is 
            int count1 = 0;
            foreach (int n in numbers1)
            {
                count1++;
            }
            Console.WriteLine(count1);

            //task2
            //counting words in a sentence
            string sentence = "hello how are you my friend";
            string[] words= sentence.Split(' ');
            int wordcount=words.Length;
            Console.WriteLine("wordcount is :"+wordcount);

            //another way to do this 

            //task 3
            //searching data in dicitiopnary
            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1, "kshitij");
            students.Add(2, "rahul");
            students.Add(3, "neha");

            //getting a value by using key
            if (students.ContainsKey(3))
            {
                Console.WriteLine(students[3]);
            }
            else
            {
                Console.WriteLine("student not found");
            }
            bool found=false;
            foreach(var item in students)
            {
                if (item.Value == "manic")
                {
                    Console.WriteLine("key is :" +item.Key);
                    found = true;
                    break;
                }
                
            }
            if (!found)
            {
                Console.WriteLine("manic was not found");
            }

        }
    }
}
