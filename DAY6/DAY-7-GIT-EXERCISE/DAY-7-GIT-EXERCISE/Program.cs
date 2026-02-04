using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_7_GIT_EXERCISE
{
    internal class Program
    {
        static void Log(string message,string path)
        {
            string logentry = $"{DateTime.Now}:{message}";
            File.AppendAllText(path, logentry + Environment.NewLine);
        }
        //for text analyzer
        //character count
        static int GetCharacterCount(string text)
        {
            return text.Length;
        }
        //word count
        static int GetWordCount(string text)
        {
            string[] words=text.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        //word count
        static string GetLongestWord(string text)
        {
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string longest = "";
            foreach (string word in words)
            {
                if(word.Length > longest.Length)
                {
                    longest = word;
                }
            }
            return longest;
        }
        static string ConvertToUpper(string text)
        {
            return text.ToUpper();
        }
        static void TextAnalayzer()
        {
            Console.Clear();
            Console.WriteLine("===TEXT ANALYZER===");
            Console.WriteLine("ENTER TEXT");
            String text=Console.ReadLine();

            int charCount=GetCharacterCount(text);
            int wordCount=GetWordCount(text);
            string longestWord=GetLongestWord(text);
            string upperText = ConvertToUpper(text);

            Console.WriteLine("\n--- Analysis Result ---");
            Console.WriteLine($"Character Count : {charCount}");
            Console.WriteLine($"Word Count      : {wordCount}");
            Console.WriteLine($"Longest Word    : {longestWord}");
            Console.WriteLine($"Uppercase Text  : {upperText}");
        }
        static void Main(string[] args)
        {
            string logpath = "app.log";
            Log("application started", logpath);
            
        }
    }
}
