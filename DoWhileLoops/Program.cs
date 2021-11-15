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
            Console.ReadLine();
        }
    }
}
