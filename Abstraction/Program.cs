using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate Employee class and fill the properties with values Sample and Student
            Employee<string> employee = new Employee<string>();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            //call SayName method from Employee class which will print out a full name
            employee.SayName();
            //create an object of IQuittable type
            IQuittable employee2 = new Employee<string>();
            //calling Quit method on employee2 object
            employee.Quit();

            //instantiate new object genericStrings from class Employee
            Employee<string> genericStrings = new Employee<string>();
            //set the value of genericStrings things property to list of strings
            genericStrings.Things = new List<string>() { "Apples", "Cheese", "Bicycle" };
            //cycle through the list of strings and print them to the console
            foreach (string genericString in genericStrings.Things)
            {
                Console.WriteLine(genericString);
            }
            Console.ReadLine();
            //instantiate new object genericNumbers from class Employee
            Employee<int> genericNumbers = new Employee<int>();
            //set the value of genericNumbers things property to list of numbers
            genericNumbers.Things = new List<int>() { 3, 6, 9 };
            //cycle through the list of numbers and print them to the console
            foreach (int genericNumber in genericNumbers.Things)
            {
                Console.WriteLine(genericNumber);
            }
            Console.ReadLine();
        }
    }
}
