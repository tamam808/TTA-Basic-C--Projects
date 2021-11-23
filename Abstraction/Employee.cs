using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Employee<T> : Person, IQuittable
    {
        //create a generic property that is a list
        public List<T> Things { get; set; }
        //create class Employee and inherit from class Person
        //create method SayName in order to fulfill the abstract method from Person class
        public override void SayName()
        {
            Console.WriteLine($"Full name: {FirstName} {LastName}");
        }

        //defined Quit method with a console.writeline
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} is quitting!");
        }
    }
}
