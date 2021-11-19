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
            //save the user input under var userNum
            int userNum = Convert.ToInt32(Console.ReadLine());
            //call the math class and name it math
            Math math = new Math();
            //call Times5 method. pass only 1 argument and save the result as method1
            int method1 = math.Times5(userNum);
            //display the result
            Console.WriteLine(userNum + " multiplied by 5 equals: " + method1);
            Console.WriteLine("Now type in a decimal.");
            //ask user for a decimal and save as a var named myDecimal
            decimal myDecimal = Convert.ToDecimal(Console.ReadLine());
            //call Times5 method. pass 2 arguments with 2nd argument being a decimal and save the result as method2
            int method2 = math.Times5(userNum, myDecimal);
            //display the result
            Console.WriteLine(userNum + " multiplied by 5 and " + myDecimal + " equals/rounds up to: " + method2);
            //ask user for another number
            Console.WriteLine("Type in another number. This number will not be converted to integer immediately.");
            //save number as a string without converting
            string numAsString = Console.ReadLine();
            //call Times5 method. pass in 2 arguments with 2nd argument being a string that can be converted to an int
            //save the result as method3
            int method3 = math.Times5(userNum, numAsString);
            //display the result
            Console.WriteLine(userNum + " multiplied by 5 and \"" + numAsString + "\" equals: " + method3);
            Console.ReadLine();
        }
    }
}
