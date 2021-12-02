using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number that I can log into a text file.");
            //save the user's input as a string with a concatenated sentence
            string userNum = "Your number is " + Console.ReadLine();
            Console.WriteLine("Logging...");
            //use File.WriteAllText to write userNum into log.txt. this line will create a new file called log.txt if it doesn't already exist
            File.WriteAllText(@"C:\Users\Tama\Documents\GitHub\TTA-Basic-Csharp-Projects\IO\log.txt", userNum);
            Console.WriteLine("This is the text that was written into the .txt file.");
            //save the text written in log.txt under a variable named fileText and write that back to the console
            string fileText = File.ReadAllText(@"C:\Users\Tama\Documents\GitHub\TTA-Basic-Csharp-Projects\IO\log.txt");
            Console.WriteLine(fileText);
            Console.ReadLine();
        }
    }
}
