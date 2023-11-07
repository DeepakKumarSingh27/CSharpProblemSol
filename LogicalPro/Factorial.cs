using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPro
{
    internal class Factorial
    {
        public void fact()
        {
            Console.Write("Enter the Number:");
            int n = int.Parse(Console.ReadLine());
            //int f1 = 0, f2 = 1;
            //while(n > 0)
            //{
            //    Console.Write(f1+" ");
            //    int f3 = f1 + f2;
            //    f1 = f2;
            //    f2 = f3;
            //    n--;
            //}
            long sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            }
            Console.WriteLine(sum);
        }
    }
}
