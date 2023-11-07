using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPro
{
    internal class PrintTenTimes
    {
        public void display()
        {
            Console.WriteLine("Enter Number : ");
            string num = Console.ReadLine();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
