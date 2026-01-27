using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAY_3_PRACTICE
{
    internal class Program
    {
        public class Contact
        {
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
        }
        static void Main(string[] args)
        {
            List<string> colors = new List<string> { "RED", "BLUE", "PURPLE" };
            foreach(var color in colors)
            {
                Console.WriteLine(color);
                
            }
            List<Contact> myfriends = new List<Contact>();
            Contact friend1 = new Contact();
            friend1.Name = "alice";
            friend1.PhoneNumber = "123234311";
            myfriends.Add(friend1);
            myfriends.Add(new Contact { Name = "kshitij", PhoneNumber = "1224342132131" });
            myfriends.Add(new Contact { Name = "charlie", PhoneNumber = "5452343432" });
            foreach (Contact friend in myfriends)
            {
                Console.WriteLine($"{friend.Name}:{friend.PhoneNumber}");
            }
            Contact c = new Contact { Name = "A", PhoneNumber = "111" };
            myfriends.Add (c);
            c.Name = "b";
            Console.WriteLine(myfriends[3].Name);
            // 📄 One paper
            //✏️ Two people holding the paper

            //If one person writes on the paper →
            //the other person sees the new text.

            //The paper = Contact object
            //Hands = references(c, myfriends[0])

            //arrrays

            string[] names = new string[3];
            names[0] = "kshitij";
            names[1] = "alice";
            names[2] = "aster";
            foreach (string name in names)
            {
                Console.WriteLine(name); 
            }
            int[] marks = { 10, 20, 30 }; //easier way to do arrays
            //when things are fixed like here subjects are fixed and marks dont dynamically grow

            //dictionaries

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
            //never access a dictionary blindly

            //updating a value

            students[2] = "aster";
            Console.WriteLine(students[2]);

            //loopig through dictionary
            foreach(var item in students)
            {
                Console.WriteLine(item.Key + "=" + item.Value);
            }
            // you use list whe order matters 
            // you want to loop in sequence 
            // you dont have a atral key
            //example
            //-todo lisy
            // menu items
            //history

            //stacks
            Console.WriteLine();

            Stack<int> numbers=new Stack<int>();
            //a stack that sotores integers

            numbers.Push(10);
            numbers.Push(20);
            numbers.Push(30);

            int removed=numbers.Pop();
            Console.WriteLine(removed);

            //just look at top
            int top = numbers.Peek();
            Console.WriteLine(top);
            //peek does not remove just shows top element 

            Console.WriteLine(numbers.Count);
            numbers.Push(10);

            //iteration patterns 
            
            //pattern 1 foreach
            foreach(int n in numbers)
            {
                Console.WriteLine(n);
            }
            //stack is not modified and iterated from top to bottom

            //pattern2 while +pop()
            //while(numbers.Count > 0)
            //{
               // Console.WriteLine(numbers.Pop());
            //}

            //stack becomes empty
            //use only when you want to consume it

            //pattern 3 -peek while iterating (safe check)
            //while (numbers.Count > 0)
            //{
                //int current = numbers.Peek();
                //Console.WriteLine(current);
                //numbers.Pop();
            //}
            //you want to inspect befrore removing

            //pattern 4-convert to array snapshot
            int[] snapshot=numbers.ToArray();
            foreach(int n in snapshot)
            {
                Console.WriteLine($"{n}");
            }
            Stack<string> undoStack = new Stack<string>();
            undoStack.Push("Typed A");
            undoStack.Push("Typed B");
            undoStack.Push("Typed C");
            while(undoStack.Count > 0)
            {
                Console.WriteLine("undo:"+undoStack.Pop());
            }

            //queues 

            Queue<string> queue= new Queue<string>();
            // aueue that stores string FIFO
            //ENQUEUE AND DEQUEUE
            queue.Enqueue("amit");
            queue.Enqueue("kshitij");
            queue.Enqueue("aster");

            //dequeue is for removing a item
            string served=queue.Dequeue();
            Console.WriteLine(served); //amit

            //to look at the front
            Console.WriteLine(queue.Peek());

            //iteraton patterns
            //same as above
            foreach(string s in queue)
            {
                Console.WriteLine(s);
            }
            //while (queue.Count > 0)
            //{
                //Console.WriteLine(queue.Dequeue());
            //}
            Console.WriteLine();

            //hashsets

            HashSet<string> emails=new HashSet<string>();
            emails.Add("a@gmail.com");
            emails.Add("b@gmail.com");
            emails.Add("a@gmail.com"); // duplicate
            //the duplicate is ignored silently 
            //no crash no error just not added

            //check if value exists
            if (emails.Contains("a@gmail.comn"))
            {
                Console.WriteLine("emaiil already exists");
            }

            foreach(string email in emails)
            {
                Console.WriteLine(email); //order not guarnteed 
            }
            //removing a value in hashset
            emails.Remove("b@gmail.com");

            //count items
            Console.WriteLine(emails.Count);
        }
    }
}
