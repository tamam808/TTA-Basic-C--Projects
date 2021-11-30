using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in the current day of the week");
            //store the user input as a string named userDay
            string userDay = Console.ReadLine();
            bool isValid = true;
            //using the bool isValid we can use a while loop to run through the program until the user enters a valid input
            while (isValid)
            {
                try
                {
                    //if the users input is valid, this variable will save without error and will display a short message
                    DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userDay);
                    Console.WriteLine("Today is " + day.ToString());
                    //we set isValid to false to stop the loop
                    isValid = false;
                }
                catch (ArgumentException)
                {
                    //we catch the argument exception error and tell the user to fix their input
                    Console.WriteLine("Please enter an actual day of the week.");
                    //save the user's new input as userDay before the loop begins again
                    userDay = Console.ReadLine();
                }
            }
            Console.ReadLine();
        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tusday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
