using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOptional
{
    class Math
    {
        public int OptionalMath(int userNum, int optionalNum = 4)
        {
            int result = userNum * optionalNum;
            return result;
        }
    }
}
