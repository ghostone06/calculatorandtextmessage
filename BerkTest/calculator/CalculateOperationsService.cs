using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerkTest.calculator
{
    public class CalculateOperationsService
    {
        public int CalculateValues(int input1, string cOperator, int input2)
        {
            int res = 0;

            switch (cOperator)
            {
                case "+":
                    res = input1 + input2;
                    break;
                case "-":
                    res = input1 - input2;
                    break;
                case "*":
                    res = input1 * input2;
                    break;
                case "x":
                    res = input1 * input2;
                    break;
                case "X":
                    res = input1 * input2;
                    break;
                case "/":
                    res = input1 / input2;
                    break;
                case "%":
                    res = input1 % input2;
                    break;
                default:
                    break;
            }

            return res;

        }
    }
}
