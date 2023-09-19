using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerkTest.calculator
{
    class OperatorCheckService
    {
        public bool OperatorCheck(string op)
        {
            var res = true;

            switch (op)
            {
                case "+":
                    res = true;
                    break;
                case "-":
                    res = true;
                    break;
                case "*":
                    res = true;
                    break;
                case "x":
                    break;
                case "X":
                    break;
                case "/":
                    break;
                case "%":
                    break;
                default:
                    Console.WriteLine("İzin Verilen Bir Operatör Girmediniz");
                    res = false;
                    break;
            }

            return res;
        }
    }
}
