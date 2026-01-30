using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_5_GIT_PRACTICE
{
    internal class Program
    {
        static void ReadFileOnStartup(string path, string logpath)
        {
            Console.WriteLine("reading file on startup ");
            if (File.Exists(path))
            {
                string[] lines1 = File.ReadAllLines(path);
                foreach (string line in lines1)
                {
                    Console.WriteLine($"Note-{line}");
                }
                Log("file read on startup", logpath);
            }
            else
            {
                Console.WriteLine("no existing file foud on startup");
                Log("file not found on starup", logpath);
            }
        }
        static void Log(string message, string path)
        {
            string logentry = $"{DateTime.Now}:{message}";
            File.AppendAllText(path, logentry + Environment.NewLine);
        }
        static void Main(string[] args)
        {
            string filePath = "myfile1.txt";
            string logpath = "app1.log";

            Log("application started", logpath);

            ReadFileOnStartup(filePath, logpath);
            
            bool run = true;
            while (run)
            {
                Console.WriteLine("1.add new note");
                Console.WriteLine("2.show notes");
                Console.WriteLine("3.exit");
                Console.WriteLine("enter your choice");

                
                if(!int.TryParse(Console.ReadLine(),out int choice))
                {
                    Console.WriteLine("invalid input. Enter a number");
                    continue;
                }

                
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("enter Note to save in file");
                        string userInput = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(userInput))
                        {
                            Console.WriteLine("note cannot be empty");
                            Log("empty note rejected", logpath);
                            break; //to prevent empty note from getting saved
                        }

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
                        break;
                    case 2:
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
                        
                        break;
                    case 3:
                        run=false;
                        Log("application ended", logpath);
                        break;

                }
            }
            

        }
    }
}
