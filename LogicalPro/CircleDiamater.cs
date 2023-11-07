using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPro
{
    internal class CircleDiamater
    {
        public void diamater()
        {
            Console.WriteLine("Enter the Radious of Circle");
            double number1 = double.Parse(Console.ReadLine());
            double d = 2 * number1;
            Console.WriteLine($"Diameter of Circle is {d}");
            double area = 3.14 * number1 * number1;
            Console.WriteLine($"Area of Circle is {area}");

        }
    }
}
