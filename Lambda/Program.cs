using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a list of employess with first and last names and an ID number
            List<string> Employees = new List<string>() { "Joe Johnson 1", "Tracy Chapman 2", "Johnny Tsunami 3",
                "Joe Jonah 4", "Mike Evans 5", "Tony Ferguson 6", "Angelina Jolie 7", "Peter Griffin 8",
                "Mickey Mouse 9", "Whitney Houston 10"};

            //loop through the list normally and return only employees names Joe
            foreach (string employee in Employees)
            {
                if (employee.Contains("Joe"))
                {
                    Console.WriteLine(employee);
                }
            }
            //use the lambda function to find employees named joe
            List<string> theJoes = Employees.Where(x => x.Contains("Joe")).ToList();
            //use the foreach loop to display those results
            foreach (string joe in theJoes)
            {
                Console.WriteLine(joe);
            }

            //use a lambda function to find employees with an ID greater than 5
            //since Employees is set up as just a list i wasn't sure how to give it official properties
            //like firstname lastname and ID so this was the only way i could think of to iterate through
            //and fulfill the requirements of the assignment
            List<string> idPlus5 = Employees.Where(x => x.Contains("6") || x.Contains("7") || 
                x.Contains("8") || x.Contains("9") || x.Contains("10")).ToList();
            //use a foreach loop to display those results
            foreach (string employee in idPlus5)
            {
                Console.WriteLine(employee);
            }
            Console.ReadLine();
        }
    }
}
