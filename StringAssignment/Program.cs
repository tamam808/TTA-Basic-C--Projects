using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite sport?");
            string sport = Console.ReadLine();
            Console.WriteLine("Which team is your favorite?");
            string team = Console.ReadLine();

            string sentence = "My name is " + name + " and my favorite sport is " + sport + ". My favorite team is the " + team + ".";

            Console.WriteLine(sentence);
            Console.WriteLine(team.ToUpper());

            StringBuilder sb = new StringBuilder();
            sb.Append("This is the first sentence. ");
            sb.Append("\nThis is the second sentence. ");
            sb.Append("\nThis is the third sentence. ");
            sb.Append("\nThis is the fourth sentence.");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
