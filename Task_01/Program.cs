using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var intCalculator = new Calculator<int>((a, b) => a + b, (a, b) => a - b, (a, b) => a * b, (a, b) => b != 0 ? a / b : throw new InvalidOperationException("Невозможно разделить на ноль."));
            intCalculator.PerformOperations(5, 3);

            var doubleCalculator = new Calculator<double>((a, b) => a + b, (a, b) => a - b, (a, b) => a * b, (a, b) => b != 0 ? a / b : throw new InvalidOperationException("Невозможно разделить на ноль."));
            doubleCalculator.PerformOperations(7.5, 2.5);
        }
    }
}
