using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPro
{
    internal class ChecksPresents
    {
        public void present()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            bool hasA = input.Contains('a');
            bool hasE = input.Contains('e');
            bool hasP = input.Contains('p');

            if (hasA && hasE && hasP)
            {
                Console.WriteLine("All Present");
            }
            else if (hasA || hasE || hasP)
            {
                Console.WriteLine("One or more - Present");

            }
            else
            {
                Console.WriteLine("None Present");
            }
        }
    }
}
