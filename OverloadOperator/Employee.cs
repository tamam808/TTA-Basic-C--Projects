using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperator
{
    public class Employee : Person
    {
        public int ID { get; set; }
        
        public override void SayName()
        {
            Console.WriteLine($"Full name: {FirstName} {LastName}");
        }

        public static bool operator== (Employee employee, Employee employee2)
        {
            bool isSame = employee.ID == employee2.ID;
            return isSame;
        }

        public static bool operator!=(Employee employee, Employee employee2)
        {
            bool isSame = employee.ID != employee2.ID;
            return isSame;
        }
    }
}
