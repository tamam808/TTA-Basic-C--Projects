using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOptional
{
    class Math
    {
        //create a new method called OptionalMath that takes at least one parameter, while the other one is optional
        //if the user doesn't provide a 2nd number it will default to 4
        public int OptionalMath(int userNum, int optionalNum = 4)
        {
            int result = userNum * optionalNum;
            return result;
        }
    }
}
