using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate Employee class
            Employee employee = new Employee();
            //set the FirstName and LastName of employee class
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            //call SayName method from Person class using Employee class
            employee.SayName();
            Console.ReadLine();
        }
    }
}
