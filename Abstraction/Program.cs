﻿using System;
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
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            //call SayName method from Employee class which will print out a full name
            employee.SayName();
            Console.ReadLine();
        }
    }
}