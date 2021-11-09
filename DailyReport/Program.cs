using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            //Simple writeline commands to display text
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
           //declare variable name as a string type and give its value whatever the console reads
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
           //declare variable course as a string type and give its value whatever the console reads
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            //declare variable page as a string type and give its value whatever the console reads
            string page = Console.ReadLine();
            //convert the value of page from string to a short
            short pageNum = Convert.ToInt16(page);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            //declare variable reply as a string type and give its value whatever the console reads
            string reply = Console.ReadLine();
            //convert the value of reply from string to boolean
            bool help = Convert.ToBoolean(reply);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            //declare variable experience as a string type and give its value whatever the console reads
            string experience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            //declare variable feedback as a string type and give its value whatever the console reads
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            //declare variable study as a string type and give its value whatever the console reads
            string study = Console.ReadLine();
            //convert the value of study from string to short
            short hours = Convert.ToInt16(study);
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            //this is here so the program doesn't immediately close after the last line of the program
            Console.ReadLine();
        }
    }
}
