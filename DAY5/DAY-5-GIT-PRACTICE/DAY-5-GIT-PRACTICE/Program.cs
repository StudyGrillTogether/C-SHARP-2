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
        static void ReadFileOnStartup(string path,string logpath)
        {
            Console.WriteLine("reading file on startup ");
            if (File.Exists(path))
            {
                string[] lines1=File.ReadAllLines(path);
                foreach(string line in lines1)
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
        static void Log(string message,string path)
        {
            string logentry=$"{DateTime.Now}:{message}";
            File.AppendAllText(path, logentry + Environment.NewLine);
            //the reason we use append is because if file doesn not exist it will create a 
            //new file
            /// enviornment.Newline insers a new line character which ensures 
            /// each log entry appears on its own line
        }
        static void Main(string[] args)
        {
            //these lines do not create files by themselves,files are created when
            //File. method is called
            string filePath = "myfile.txt";
            string logpath = "app.log";

            Log("application started",logpath);

            ReadFileOnStartup(filePath, logpath);

            Console.WriteLine("enter text to save in file");
            string userInput=Console.ReadLine();
            
            try
            {
                File.AppendAllText(filePath, userInput+Environment.NewLine);
                Console.WriteLine("file saved succesfully");
                Log("text saved to myfile.txt", logpath);

            }
            catch(IOException ex)
            {
                Console.WriteLine("error while saving:" + ex.Message);
                Log("error while saving file:"+ex.Message, logpath);
            }
            Console.WriteLine("do you want to read the contents of file ");
            string read=Console.ReadLine();
            
            if (read.Trim().ToLower() =="yes")
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
            else
            {
                Console.WriteLine("your input is wrong");
                Log("file not found while reading", logpath);
            }
            Log("application ended", logpath);
        }
    }
}
