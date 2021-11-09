using System;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number");
            string number = Console.ReadLine();
            int num1 = Convert.ToInt32(number);
            int times50 = num1 * 50;
            Console.WriteLine("Your number times 50 is: " + times50);
            Console.WriteLine("Type another number");
            string number2 = Console.ReadLine();
            int num2 = Convert.ToInt32(number2);
            int plus25 = num2 + 25;
            Console.WriteLine("Your number plus 25 is: " + plus25);
            Console.WriteLine("Type another number");
            string number3 = Console.ReadLine();
            float num3 = float.Parse(number3);
            float divide = num3 / (float)12.5;
            Console.WriteLine("Your number divided by 12.5 is : " + divide);
            Console.WriteLine("Type another number");
            string number4 = Console.ReadLine();
            int num4 = Convert.ToInt32(number4);
            bool greater = num4 > 50;
            Console.WriteLine("Is your number greater than 50? " + greater);
            Console.WriteLine("Type another number");
            string number5 = Console.ReadLine();
            int num5 = Convert.ToInt32(number5);
            int remainder = num5 % 7;
            Console.WriteLine("When your number is divided by 7, the remainder is: " + remainder);
            Console.ReadLine();
        }
    }
}
