using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DAY_7_GIT_EXERCISE
{
    internal class Program
    {
        static string logpath = "app.log";
        static string filePath = "myfile.txt";
        static void Log(string message,string path)
        {
            string logentry = $"{DateTime.Now}:{message}";
            File.AppendAllText(path, logentry + Environment.NewLine);
        }
        //for text analyzer
        //character count
        static int GetCharacterCount(string text)
        {
            Log("character count retreived", logpath);
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
        static void Pause()
        {
            Console.WriteLine("\n press any key to return to menu");
            Console.ReadKey();
        }

        //Number Statistics
        static void NumberStastics()
        {
            Console.Clear();//wipess the console screen clean making it easier to read the fesh stuff
            Console.WriteLine("===Number Statistics===");
            Console.WriteLine("enter numbers sepearated by commas:");
            string input=Console.ReadLine();
            string[] parts = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            // breaks into new char array ["10","20","30","40"]
            int[] numbers = new int[parts.Length];
            int index = 0;
            
            foreach(string part in parts)
            {
                if(!int.TryParse(part.Trim(), out numbers[index]))
                {
                    Console.WriteLine("Invalid number detected.enter valid ones");
                    Pause();
                    return;
                }
                index++;
            }
            int count=numbers.Length;
            int sum = 0;
            int min = numbers[0];
            int max=numbers[0];
            
            foreach(int num in numbers)
            {
                sum=sum+num;
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max= num;
                }
            }
            double average=(double)sum/count;

            Console.WriteLine("\n--- Statistics ---");
            Console.WriteLine($"Count   : {count}");
            Console.WriteLine($"Sum     : {sum}");
            Console.WriteLine($"Average : {average}");
            Console.WriteLine($"Minimum : {min}");
            Console.WriteLine($"Maximum : {max}");
            Log("applications on number statistics is done", logpath);

            Pause();
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
            Pause();
        }

        //Notes Manager
        static void ReadFileOnStartup(string path, string logpath)
        {
            Console.WriteLine("reading file on startup ");
            if (File.Exists(path))
            {
                string[] lines1 = File.ReadAllLines(path);
                foreach (string line in lines1)
                {
                    Console.WriteLine($"{line}");
                }
                Log("file read on startup", logpath);
            }
            else
            {
                Console.WriteLine("no existing file foud on startup");
                Log("file not found on starup", logpath);
            }
        }

        static void NotesManager()
        {
            Console.WriteLine("enter text to save in a file");
            string userInput=Console.ReadLine();

            try
            {
                File.AppendAllText(filePath, userInput + Environment.NewLine);
                Console.WriteLine("file saved succesfully");
                Log("text saved to myfile.txt", logpath);

            }
            catch (IOException ex)
            {
                Console.WriteLine("error while saving:" + ex.Message);
                Log("error while saving file:" + ex.Message, logpath);
            }
            Console.WriteLine("do you want to read the contents of file ");
            string read = Console.ReadLine().Trim().ToLower();

            if (read== "yes")
            {
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                    Log("file read successfully", logpath);
                }
                else
                {
                    Console.WriteLine("file not found");
                    Log("file not found while reading", logpath);
                }
            }
            else if (read == "no")
            {
                Console.WriteLine("returning to menu");
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
            Pause();
            Log("Notes manager operation completed", logpath);

        }
        static void Applogs()
        {
            Console.WriteLine("=====all the logs till now=====");
            if (File.Exists(logpath))
            {
                string[] logs = File.ReadAllLines(logpath);
                foreach(string log in logs)
                {
                    Console.WriteLine(log);
                }
            }
            else
            {
                Console.WriteLine("No logs found");
            }
            Log("READING LOGS APPLICATION ENDED", logpath);
            Pause();
        }
        static void Main(string[] args)
        {
            
            
            Log("application started", logpath);
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("=== CONSOLE UTILITY TOOLKIT ===");
                Console.WriteLine("1. Text Analyzer");
                Console.WriteLine("2. Number Statistics");
                Console.WriteLine("3. Notes Manager");
                Console.WriteLine("4. App Logs");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                if(!int.TryParse(Console.ReadLine(),out int choice))
                {
                    Console.WriteLine("Invalid input.Press any key to continue");
                    Console.ReadKey();
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        TextAnalayzer();
                        Log("Text analyzer ended", logpath);
                        break;
                    case 2:
                        NumberStastics();
                        Log("Number statistics ended ", logpath);
                        break;
                    case 3:
                        ReadFileOnStartup(filePath,logpath);
                        NotesManager();
                        break;
                    case 4:
                        Applogs();
                        break;
                    case 5:
                        Console.WriteLine("Exiting the application");
                        File.WriteAllText(logpath, string.Empty);
                        File.WriteAllText(filePath, string.Empty);
                        isRunning = false;
                        break;
                    ///if app.log  exist it becomes empty
                    ///if it doesn't exist it creates it 
                    default:
                        Console.WriteLine("invalid menu choice.");
                        Pause();
                        break;


                }
            }


            
        }
    }
}
