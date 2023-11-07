using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPro
{
    internal class TwoNumberSumOrDiff
    {
        public void sqrt1()
        {
            Console.Write("Enter the first number: ");
            double number1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double number2 = double.Parse(Console.ReadLine());
            double sum = number1 + number2;
            double squareOfSum = sum * sum;
            double difference = number1 - number2;
            double squareOfDifference = difference * difference;
            Console.WriteLine($"Square of the sum: {squareOfSum}");
            Console.WriteLine($"Square of the difference: {squareOfDifference}");
            Console.ReadLine();
        }
    }
}
