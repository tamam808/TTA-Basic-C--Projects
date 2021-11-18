using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a number");
            int userNum = Convert.ToInt32(Console.ReadLine());
            Math math = new Math();
            int method1 = math.Times5(userNum);
            Console.WriteLine(userNum + " multiplied by 5 equals: " + method1);
            Console.WriteLine("Now type in a decimal.");
            decimal myDecimal = Convert.ToDecimal(Console.ReadLine());
            int method2 = math.Times5(userNum, myDecimal);
            Console.WriteLine(userNum + " multiplied by 5 and " + myDecimal + " equals/rounds up to: " + method2);
            Console.WriteLine("Type in another number. This number will not be converted to integer immediately.");
            string numAsString = Console.ReadLine();
            int method3 = math.Times5(userNum, numAsString);
            Console.WriteLine(userNum + " multiplied by 5 and \"" + numAsString + "\" equals: " + method3);
            Console.ReadLine();
        }
    }
}
