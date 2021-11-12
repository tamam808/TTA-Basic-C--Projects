using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string Age = Console.ReadLine();
            int yearsold = Convert.ToInt32(Age);
            Console.WriteLine("Have you ever had a DUI? Type \"true\" or \"false\"");
            string dui = Console.ReadLine();
            bool dui_bool = Convert.ToBoolean(dui);
            Console.WriteLine("How many speeding tickets do you have?");
            string tix = Console.ReadLine();
            int speeding = Convert.ToInt32(tix);
            Console.WriteLine("Qualified?");
            Console.WriteLine(yearsold >= 15 && dui_bool == false && speeding <= 3);
            Console.ReadLine();
        }
    }
}
