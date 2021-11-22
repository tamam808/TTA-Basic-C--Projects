using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number");
            //save the user's input as var userNum and call the Math class' Divide method
            int userNum = Convert.ToInt32(Console.ReadLine());
            Math.Divide(userNum);
            Console.WriteLine("Please input another number");
            //save the user's input as var userNum2
            int userNum2 = Convert.ToInt32(Console.ReadLine());
            //call Math class' Divide method and save the result as var answers
            int answers = Math.Divide(userNum, userNum2, out int times5);
            Console.WriteLine($"{userNum} divided by 2 equals: {answers}");
            Console.WriteLine($"{userNum2} multiplied by 5 equals: {times5}");
            Console.ReadLine();
        }
    }
}
