using BerkTest.calculator;
using System;

namespace BerkTest
{
    class Program
    {
        public void Main(string[] args)
        {
            var stopper = "";
            CalculatorService calc = new CalculatorService();
            do
            {
                calc.CalculateOperations();
                Console.WriteLine("Çıkmak için exit yazabilirsiniz");
                stopper = Console.ReadLine();
                Console.Clear();
            } while (stopper != "exit");
        }
    }

    class MainProgram
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Main(args);
        }
    }
}
