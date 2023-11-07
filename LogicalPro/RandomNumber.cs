using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPro
{
    internal class RandomNumber
    {
        public void Random() {
            Random random = new Random();

            int sum = 0;
            int[] arr = new int[5];

            for (int i = 0; i < 5; i++)
            {
                int randomNumber = random.Next(10, 51);
                sum += randomNumber;
                arr[i] = randomNumber;
            }

            double average = (double)sum / 5;

            Console.WriteLine("Generated numbers: " + string.Join(", ", arr));

            Console.WriteLine("Average: " + average);
        }
    }
}
