using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class MyMath
    {
        public double result;
        public double operand1;
        public double operand2;

        public double AddNumbers(double op1, double op2)
        {
            operand1 = op1;
            operand2 = op2;
            result = operand1 + operand2;
            return result;
        }

    public void Multiply(double op1, double op2,)

        {
            operand1 = op1;
            operand2 = op2;
            result = operand1 * operand2;
        }


    }
}
