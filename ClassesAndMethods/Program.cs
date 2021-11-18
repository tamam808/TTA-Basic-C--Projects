using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in a number");
            int userNum = Convert.ToInt32(Console.ReadLine());
            MathMethods m = new MathMethods();
            double divided = m.DivideBy2(userNum);
            int multiplied = m.Times5(userNum);
            int added = m.Plus50(userNum);
            Console.WriteLine(userNum + " multiplied by 5 equals: " + multiplied);
            Console.WriteLine(userNum + " divided by 2 equals: " + divided);
            Console.WriteLine(userNum + " added by 50 equals: " + added);
            Console.ReadLine();
        }
    }
}
