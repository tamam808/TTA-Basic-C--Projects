using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Person
    {
        //create abstract class Person and give it 2 string properties FirstName and LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //also give it an abstract method SayName. this means that any inheriting classes
        //NEED a method with this name in order for the program to run
        public abstract void SayName();
    }
}
