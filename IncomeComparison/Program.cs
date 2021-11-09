using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate:");
            //declare variable num1 and give it the value of the input
            string num1 = Console.ReadLine();
            //convert the data type of num1 to float since it may include decimal point
            float person1Rate = float.Parse(num1);
            Console.WriteLine("Hours worked per week:");
            //declare variable num2 and give it the value of the input
            string num2 = Console.ReadLine();
            //convert the data type of num2 to int
            int person1Hours = Convert.ToInt32(num2);
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate:");
            //declare variable num3 and give it the value of the input
            string num3 = Console.ReadLine();
            //convert the data type of num3 to float since it may include decimal point
            float person2Rate = float.Parse(num3);
            Console.WriteLine("Hours worked per week:");
            //declare variable num4 and give it the value of the input
            string num4 = Console.ReadLine();
            //convert the data type of num4 to int
            int person2Hours = Convert.ToInt32(num4);
            //multiply each person's rate by their hours and also by 52 for all the weeks in a year
            float person1Salary = person1Rate * person1Hours * 52;
            float person2Salary = person2Rate * person2Hours * 52;
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(person1Salary);
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(person2Salary);
            //compare person1salary and person2 salary using a greater than symbol
            bool makesMore = person1Salary > person2Salary;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(makesMore);
            Console.ReadLine();
        }
    }
}
