using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPro
{
    internal class NextDay
    {
        public void Next() {
            Console.WriteLine("Enter the Year ");
            int yy = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Month ");
            int mm = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Day ");
            int dd = int.Parse(Console.ReadLine());
            Console.WriteLine("The Next Days is "+yy +"-"+mm+"-"+(dd+1));

        }
    }
}
