using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerkTest.calculator
{
    public class CalculatorService
    {
        public void CalculateOperations()
        {
            int val1;
            int val2;
            string calculatorOperator;
            bool opChecker;
            OperatorCheckService oprtC = new OperatorCheckService();
            CalculateOperationsService calcOprtS = new CalculateOperationsService();
            OperatorCheckService oprtCheckS = new OperatorCheckService();

            Console.WriteLine("İlk Sayıyı Girin:");
            val1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Yapmak İstediğiniz işlem operatörünü girin:");
            calculatorOperator = Console.ReadLine();
            opChecker = oprtC.OperatorCheck(calculatorOperator);

            if (opChecker)
            {
                Console.WriteLine("İkinci Sayıyı Girin:");
                val2 = Convert.ToInt16(Console.ReadLine());
                var sum = calcOprtS.CalculateValues(val1, calculatorOperator, val2);
                Console.WriteLine("Sonuç = " + sum);
            }
            else
            {
                while (!opChecker)
                {
                    Console.WriteLine("Yapmak İstediğiniz işlem operatörünü tekrar girin:");
                    calculatorOperator = Console.ReadLine();
                    opChecker = oprtCheckS.OperatorCheck(calculatorOperator);
                }
                Console.WriteLine("İkinci Sayıyı Girin:");
                val2 = Convert.ToInt16(Console.ReadLine());
                var sum = calcOprtS.CalculateValues(val1, calculatorOperator, val2);
                Console.WriteLine("Sonuç: " + val1 + " " + calculatorOperator + " " + val2 + " = " + sum);
            }
        }
    }
}
