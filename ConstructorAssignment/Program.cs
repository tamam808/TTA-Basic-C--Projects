using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a const string here to set the name of the program as this will never change
            const string progName = "Constructor Assignment";
            Console.WriteLine($"The name of this submission is \"{progName}\"");
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int playerAge = Convert.ToInt32(Console.ReadLine());
            //after asking for the user's name and age, we will use the constructor we made in the
            //person class to create players using the variables to fulfill the parameters
            var player = new Person(playerName, playerAge);
            //here we create a 2nd player using the constructor that is chained
            //passing in only the string var and forcing the constructor to set his age to 21 as the code says
            var player2 = new Person("Jim");
            //simply show that info to the console to verify that the code works
            Console.WriteLine($"Player 1 is {player.Name} and they are {player.Age} years old.");
            Console.WriteLine($"Player 2 is {player2.Name} and they are {player2.Age} years old.");
            Console.ReadLine();
        }
    }
}
