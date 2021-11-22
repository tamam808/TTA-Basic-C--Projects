using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Employee : Person
    {
        //create class Employee and inherit from class Person
        //create method SayName in order to fulfill the abstract method from Person class
        public override void SayName()
        {
            Console.WriteLine($"Full name: {FirstName} {LastName}");
        }
    }
}
