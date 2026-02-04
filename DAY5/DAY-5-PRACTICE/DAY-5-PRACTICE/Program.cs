using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DAY_5_PRACTICE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///If data.txt does NOT exist → ✅ it creates the file and writes:
            ///If data.txt already exists → ⚠️ it overwrites everything in the file with that text.

            File.WriteAllText("data.txt", "hello c# , file wiriting");

            // Appends text to the end of the file without removing existing content.
            // If the file does not exist, it will be created.

            File.AppendAllText("data.txt", "\n appending the text");
            //reading from a file
            string content = File.ReadAllText("data.txt");
            Console.WriteLine(content);
            //reading line by line
            string[] lines = File.ReadAllLines("data.txt");
            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
            //2.Reading and writing using streams
            //writing using streamwrite
            using(StreamWriter writer=new StreamWriter("stream.txt"))
            {
                writer.WriteLine("first line");
                writer.WriteLine("second line");
            }
            //Reading using streamwriter
            using (StreamReader reader = new StreamReader("stream.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            //using exception handling in file I/O
            try
            {
                string text = File.ReadAllText("test.txt");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("file not found");
            }
            catch (IOException)
            {
                Console.WriteLine("file I/O error");
            }

            // handling missing files 
            string path = "data.txt";
            if (File.Exists(path))
            {
                string contents=File.ReadAllText(path);
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("file does not exists");
            }
            //another way is above using exceptions
            //creating a file if it doesn't exist

            string path1 = "data1.txt";
            if (!File.Exists(path1))
            {
                File.Create(path1).Close();
            }
            //using streamreader with safety check
            if (File.Exists("info.txt"))
            {
                using(StreamReader reader=new StreamReader("info.txt"))
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("file missing");
            }
        }
    }
}
