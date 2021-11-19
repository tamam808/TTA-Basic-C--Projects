using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class Math
    {
        //we use method overloading to use the same name for these methods
        //as long as each method calls for different parameters
        public int Times5(int userNum)
        {
            //this method only asks for one parameter and will multiply it by 5
            int result = userNum * 5;
            return result;
        }

        public int Times5(int userNum, decimal myDecimal)
        {
            //this method will ask for 2 parameters and it will multiply those numbers together and then by 5
            decimal result = userNum * 5 * myDecimal;
            Convert.ToInt32(result);
            return (int)result;
        }

        public int Times5(int userNum, string numAsString)
        {
            //this method will ask for 2 parameters and since one is a string we have to convert it first
            //then it will multiply those numbers together and then by 5
            int stringToInt = Convert.ToInt32(numAsString);
            int result = userNum * 5 * stringToInt;
            return result;
        }
    }
}
