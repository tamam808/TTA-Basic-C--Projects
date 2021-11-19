using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodVoid
{
    class VoidMethod
    {
        //created a void method which means it doesn't need to return a value
        public void Method1(int userNum1, int userNum2)
        {
            //do a math operation to the 1st integer
            int result = userNum1 * 100;
            //display the 2nd integer
            Console.WriteLine(userNum2);
        }
    }
}
