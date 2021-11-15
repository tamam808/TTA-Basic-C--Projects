using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = { "Billy", "Joey", "Tony", "Joseph", "Eric" };
            Console.WriteLine("Type a number");
            int stringArrayIndex = Convert.ToInt32(Console.ReadLine());
            bool stringIndexExists = false;
            while (!stringIndexExists)
            {
                if (stringArrayIndex <= stringArray.Length - 1)
                {
                    Console.WriteLine(stringArray[stringArrayIndex]);
                    stringIndexExists = true;
                    
                }
                else
                {
                    Console.WriteLine("That index does not exist.");
                    Console.WriteLine("Try again");
                    stringArrayIndex = Convert.ToInt32(Console.ReadLine());
                }
            }
            int[] intArray = { 5, 12, 54, 23, 543, 17 };
            Console.WriteLine("Type a number");
            int intArrayIndex = Convert.ToInt32(Console.ReadLine());
            bool intIndexExists = false;
            while (!intIndexExists)
            {
                if (intArrayIndex <= intArray.Length - 1)
                {
                    Console.WriteLine(intArray[intArrayIndex]);
                    intIndexExists = true;
                    
                }
                else
                {
                    Console.WriteLine("That index does not exist.");
                    Console.WriteLine("Try again");
                    intArrayIndex = Convert.ToInt32(Console.ReadLine());
                }
            }
            List<string> stringList = new List<string>();
            stringList.Add("Howdy");
            stringList.Add("Tama");
            stringList.Add("Jimmy");
            stringList.Add("Billy");

            Console.WriteLine("Type a number");
            int stringListIndex = Convert.ToInt32(Console.ReadLine());
            bool listIndexExists = false;
            while (!listIndexExists)
            {
                if (stringListIndex <= stringList.Count)
                {
                    Console.WriteLine(stringList[stringListIndex]);
                    listIndexExists = true;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("That index does not exist.");
                    Console.WriteLine("Try again");
                    stringListIndex = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
