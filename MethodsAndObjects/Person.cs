using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Person
    {
        //give class Person 2 string properties called FirstName and LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //create a method to call that will display the full name
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
