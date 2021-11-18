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
            int result;
            result = userNum * 5;
            return result;
        }
        public double DivideBy2(int userNum)
        {
            double result;
            result = (double)userNum / 2;
            return result;
        }
        public int Plus50(int userNum)
        {
            int result;
            result = userNum + 50;
            return result;
        }
    }
}
