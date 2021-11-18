using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class Math
    {
        public int Times5(int userNum)
        {
            int result = userNum * 5;
            return result;
        }

        public int Times5(int userNum, decimal myDecimal)
        {
            decimal result = userNum * 5 * myDecimal;
            Convert.ToInt32(result);
            return (int)result;
        }

        public int Times5(int userNum, string numAsString)
        {
            int stringToInt = Convert.ToInt32(numAsString);
            int result = userNum * 5 * stringToInt;
            return result;
        }
    }
}
