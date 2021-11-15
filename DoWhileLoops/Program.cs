using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in your name");
            string name = Console.ReadLine();
            bool user = name == "Tama";

            do
            {
                switch (name)
                {
                    case "Tama":
                        Console.WriteLine("Welcome back, Tama");
                        user = true;
                        break;
                    case "Jimmy":
                        Console.WriteLine("Hello Jimmy, please use your own computer");
                        Console.WriteLine("Please type in your name");
                        name = Console.ReadLine();
                        break;
                    case "Tanya":
                        Console.WriteLine("Hello Tanya, please use your own computer");
                        Console.WriteLine("Please type in your name");
                        name = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Name not recgonized. Try again");
                        Console.WriteLine("Please type in your name");
                        name = Console.ReadLine();
                        break;
                }
            }
            while (!user);
            Console.WriteLine("Please type in a month");
            string month = Console.ReadLine();
            bool favMonth = false;

            while (!favMonth)
            {
                switch (month)
                {
                    case "January":
                        Console.WriteLine(month + " is not the best month");
                        Console.WriteLine("Please type in a month");
                        month = Console.ReadLine();
                        break;
                    case "March":
                        Console.WriteLine(month + " is not the best month");
                        Console.WriteLine("Please type in a month");
                        month = Console.ReadLine();
                        break;
                    case "April":
                        Console.WriteLine(month + " is not the best month");
                        Console.WriteLine("Please type in a month");
                        month = Console.ReadLine();
                        break;
                    case "February":
                        Console.WriteLine("February is the best month");
                        favMonth = true;
                        break;
                    case "May":
                        Console.WriteLine(month + " is not the best month");
                        Console.WriteLine("Please type in a month");
                        month = Console.ReadLine();
                        break;
                    case "June":
                        Console.WriteLine(month + " is not the best month");
                        Console.WriteLine("Please type in a month");
                        month = Console.ReadLine();
                        break;
                    case "July":
                        Console.WriteLine(month + " is not the best month");
                        Console.WriteLine("Please type in a month");
                        month = Console.ReadLine();
                        break;
                    case "August":
                        Console.WriteLine(month + " is not the best month");
                        Console.WriteLine("Please type in a month");
                        month = Console.ReadLine();
                        break;
                    case "September":
                        Console.WriteLine(month + " is not the best month");
                        Console.WriteLine("Please type in a month");
                        month = Console.ReadLine();
                        break;
                    case "October":
                        Console.WriteLine(month + " is not the best month");
                        Console.WriteLine("Please type in a month");
                        month = Console.ReadLine();
                        break;
                    case "November":
                        Console.WriteLine(month + " is not the best month");
                        Console.WriteLine("Please type in a month");
                        month = Console.ReadLine();
                        break;
                    case "December":
                        Console.WriteLine(month + " is not the best month");
                        Console.WriteLine("Please type in a month");
                        month = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine(month + " is not recognized as a month.");
                        Console.WriteLine("Try again.");
                        month = Console.ReadLine();
                        break;
                }
                
            }
            Console.ReadLine();
        }
    }
}
