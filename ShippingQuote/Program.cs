using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.");
            Console.WriteLine("Please input the weight of the package in pounds(lbs).");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day. ");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Please input the width of the package in inches.");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the height of the package in inches.");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the length of the package in inches.");
            int length = Convert.ToInt32(Console.ReadLine());
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }
            decimal quote = (((decimal)width * (decimal)length * (decimal)height) * (decimal)weight) / 100;
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
