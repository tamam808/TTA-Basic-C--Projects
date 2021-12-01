using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object of data type Number
            Number myNum = new Number();
            //assign it a value
            myNum.Amount = 24.80m;
            //print to console
            Console.WriteLine(myNum.Amount);
            Console.ReadLine();
        }
    }
}
