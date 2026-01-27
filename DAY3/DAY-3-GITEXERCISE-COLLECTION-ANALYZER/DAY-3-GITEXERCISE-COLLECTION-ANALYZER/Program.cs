using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_3_GITEXERCISE_COLLECTION_ANALYZER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a sentence");
            string sentence=Console.ReadLine();
            string[] rawwords=sentence.ToLower().Split(' ');
            List<string> words=new List<string>();
            foreach (string w in rawwords)
            {
                words.Add(w);
            }
            //creating dicitionary for frequency
            Dictionary<string,int> frequency=new Dictionary<string,int>();
            foreach(string word in words)
            {
                if (frequency.ContainsKey(word))
                {
                    frequency[word] = frequency[word]+1;//Key (string) → Value (number)

                }
                else
                {
                    frequency.Add(word, 1);
                }
            }
            // if word already exists increase count 
            //else add word with count=1

            foreach(var item in frequency)
            {
                Console.WriteLine($"{item.Key}:: {item.Value}");
            }
        }
    }
}
