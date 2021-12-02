using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current date and time is: " + DateTime.Now);
            Console.WriteLine("Please input a whole number");
            //save the user input as an integer named userHrs
            int userHrs = Convert.ToInt32(Console.ReadLine());
            //use the DateTime.AddHours function to add userHrs to DateTime.Now. save that DateTime as hrs Later
            DateTime hrsLater = DateTime.Now.AddHours(userHrs);
            //display that new info to the user
            Console.WriteLine($"In {userHrs} hours it will be {hrsLater}");
            
            
            Console.ReadLine();
        }
    }
}
