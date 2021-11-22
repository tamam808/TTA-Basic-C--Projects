using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndClasses
{
    //created a static class
    static class Math
    {
        //create void method Divide
        public static void Divide(int userNum)
        {
            int result = userNum / 2;
            Console.WriteLine(userNum + " divided by 2 equals: " + result);
        }
        //overload Divide method with an out parameter
        public static int Divide(int userNum, int userNum2, out int times5)
        {
            times5 = userNum2 * 5;
            int result = userNum / 2;
            return result;
        }
    }
}
