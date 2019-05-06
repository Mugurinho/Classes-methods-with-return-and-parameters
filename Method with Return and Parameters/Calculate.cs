using System;
using System.Collections.Generic;
using System.Text;

namespace Method_with_Return_and_Parameters
{
    class Calculate
    {
        public int Sum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }

        public int Final(int sum, int cube)
        {
            int final = sum + cube;
            return final;
        }
    }
}
