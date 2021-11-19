using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodVoid
{
    class Program
    {
        static void Main(string[] args)
        {
            //call the VoidMethod class and save it as math
            VoidMethod math = new VoidMethod();
            Console.WriteLine("Please type in your first number");
            //ask for the user to input a number. save it as userNum1
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type in your second number");
            //ask for another number. save it as userNum2
            int userNum2 = Convert.ToInt32(Console.ReadLine());
            //call Method1 and pass it the arguments that have been provided by the user
            math.Method1(userNum1, userNum2);
            Console.ReadLine();
        }
    }
}
