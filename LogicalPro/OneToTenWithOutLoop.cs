using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPro
{
    internal class OneToTenWithOutLoop
    {
        public void print1(int n)
        {
            if (n ==101)
            {
                return;
            }
            Console.WriteLine(n);
            print1(++n);

        }
    }
}
