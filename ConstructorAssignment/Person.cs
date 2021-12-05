using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Person
    {
        //this constructor is chained to the other Person constructor
        //if a Person type object is created passing only the name as an argument
        //this constructor will automatically set the age of that player to 21
        public Person(string name) : this(name, 21)
        {
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
