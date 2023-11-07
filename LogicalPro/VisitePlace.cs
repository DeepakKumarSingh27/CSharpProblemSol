using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPro
{
    internal class VisitePlace
    {
        public void display()
        {
            Console.WriteLine("Enter Place Name where you visite: ");
            string place = Console.ReadLine();
            Console.WriteLine(place.ToUpper());
            Console.WriteLine(place.ToLower());
            Console.ReadKey();
        }
    }
}
