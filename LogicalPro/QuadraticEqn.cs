using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPro
{
    internal class QuadraticEqn
    {
        public void root()
        {
            Console.WriteLine("Enter the coefficients of the quadratic equation (a, b, c):");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double discriminant = (b * b) - (4 * a * c);

            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Two distinct real roots: Root1 = {root1}, Root2 = {root2}");
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine($"One real root: Root = {root}");
            }
            else
            {
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
                Console.WriteLine($"Two complex roots: Root1 = {realPart} + {imaginaryPart}i, Root2 = {realPart} - {imaginaryPart}i");
            }
       
        }
    }
}
