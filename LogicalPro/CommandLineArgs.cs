using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPro
{
    internal class CommandLineArgs
    {
        public  CommandLineArgs(String[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide a full name as a command-line argument.");
                return;
            }
            string fullName = string.Join(" ", args);
            string[] nameParts = fullName.Split(' ');
            int numberOfParts = nameParts.Length;
            Console.WriteLine($"Number of parts in the name: {numberOfParts}");
            Console.WriteLine($"Full Name: {fullName}");
        }
    }
}
