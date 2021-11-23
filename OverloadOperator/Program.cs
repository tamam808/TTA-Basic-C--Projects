using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student", ID = 1};
            Employee employee2 = new Employee() { FirstName = "Other", LastName = "Student", ID = 2};
            bool isSame = employee == employee2;
            Console.WriteLine($"Are the employees the same person?");
            Console.WriteLine(isSame);
            Console.ReadLine();
        }
    }
}
