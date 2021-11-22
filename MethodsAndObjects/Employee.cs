using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Employee : Person
    {
        //use ": Person" to have Employee class inherit Person's properties
        //add a property unique to Employee called Id
        public int Id { get; set; }
    }
}
