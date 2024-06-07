using System;

namespace GitHubMainApplication
{
    internal class TotalOfAllValues
    {
        public void calculateTotalOfAllValues(int[] numbersArray) {
            int sum = 0;
            foreach (int number in numbersArray) { 
            sum+= number;
            }
            Console.WriteLine($"The sum of all the numbers is: {sum}");

        }
    }
}
