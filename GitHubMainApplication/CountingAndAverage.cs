using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubMainApplication
{
    public class CountingAndAverage
    {
        // Method to count the number of elements
        public void count( int count)
        {
            Console.WriteLine($"Number of elements in the array at present is {count}");
        }
        public void average( int[] Storage,  int count)
        {
            int average = 0;
            int total = 0;
            for (int iterator = 0; iterator < count; iterator++)
            {
                //Hetting the sum of elements in the each iteration
                total += Storage[iterator];
            }
            // Calculating average
            average = total / count;
            Console.WriteLine($"average is {average}");
        }
    }
}


