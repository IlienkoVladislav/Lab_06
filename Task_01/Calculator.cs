using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public class Calculator<T>
    {
        public delegate T OperationDelegate(T a, T b);

        public OperationDelegate Add { get; set; }
        public OperationDelegate Subtract { get; set; }
        public OperationDelegate Multiply { get; set; }
        public OperationDelegate Divide { get; set; }

        public Calculator(OperationDelegate add, OperationDelegate subtract, OperationDelegate multiply, OperationDelegate divide)
        {
            Add = add;
            Subtract = subtract;
            Multiply = multiply;
            Divide = divide;
        }

        public void PerformOperations(T operand1, T operand2)
        {
            Console.WriteLine($"Оператор 1: {operand1}");
            Console.WriteLine($"Оператор 2: {operand2}");
            Console.WriteLine($"Сума: {Add(operand1, operand2)}");
            Console.WriteLine($"Різниця: {Subtract(operand1, operand2)}");
            Console.WriteLine($"Результат: {Multiply(operand1, operand2)}");
            Console.WriteLine($"Частка: {Divide(operand1, operand2)}");
            Console.WriteLine();
        }
    }
}
