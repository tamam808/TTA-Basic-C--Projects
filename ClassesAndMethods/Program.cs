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
            //save the user's input here as an integer called userNum
            int userNum = Convert.ToInt32(Console.ReadLine());
            //call the class MathMethods and save it here as m
            MathMethods m = new MathMethods();
            //call the method DivideBy2 from the class MathMethods and pass the argument userNum
            //save that result as var divided
            double divided = m.DivideBy2(userNum);
            //call the method Times5 from the class MathMethods and pass the argument userNum
            //save that result as var multiplied
            int multiplied = m.Times5(userNum);
            //call the method Plus50 from the class MathMethods and pass the argument userNum
            //save that result as added
            int added = m.Plus50(userNum);
            //ouput the results of those methods here with some string to make it more presentable
            Console.WriteLine(userNum + " multiplied by 5 equals: " + multiplied);
            Console.WriteLine(userNum + " divided by 2 equals: " + divided);
            Console.WriteLine(userNum + " added by 50 equals: " + added);
            Console.ReadLine();
        }
    }
}
