using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods
{
    class MathMethods
    {
        public int Times5(int userNum)
        {
            //this method will take userNum and multiply it by 5
            int result;
            result = userNum * 5;
            return result;
        }
        public double DivideBy2(int userNum)
        {
            //this method will take userNum and divide it by 2
            //i convert userNum to a double and make the result variable a double type as well
            //because the answer to this math operation can include a decimal point
            double result;
            result = (double)userNum / 2;
            return result;
        }
        public int Plus50(int userNum)
        {
            //this method will take userNum and add 50 to it
            int result;
            result = userNum + 50;
            return result;
        }
    }
}
