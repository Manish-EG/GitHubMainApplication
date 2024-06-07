using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubMainApplication
{
    internal class Program
    {
        static void displayOptions() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1- Insert an element");
            Console.WriteLine("2- Delete an element");
            Console.WriteLine("3- Sort the elements");
            Console.WriteLine("4- Count of elements in the array");
            Console.WriteLine("6- Compute the average of all values ");
            Console.WriteLine("7- Find the maximum and minimum value");
            Console.WriteLine("8- Calculate total of all the values");
            Console.WriteLine("9- Exit");
            Console.WriteLine("----------------------------------------");
            Console.ForegroundColor= ConsoleColor.White;
            Console.Write("Enter your choice:");
        }
        static void Main(string[] args)
        {
            int countOfNumbers;
            int[] numbersArray=new int[15];
            int choice;

            Console.Write("Enter the number of elements: ");
            countOfNumbers = Convert.ToInt32(Console.ReadLine());

            for (int iterator = 0; iterator < countOfNumbers; iterator++) {
                Console.Write($"Enter the number-{iterator}: ");
                numbersArray[iterator]=Convert.ToInt32(Console.ReadLine());
            }

            displayOptions();
            choice=Convert.ToInt32(Console.ReadLine());
            while (true) {
                switch (choice) { 
                case 1:
                        break;
                case 2:
                        GitHubMainApplication.DeletionOperation.Deletion(numbersArray, countOfNumbers);
                        countOfNumbers--;
                        break;
                case 3:break;
                case 4:break;
                case 5:break;
                case 6:break;
                case 7:break;
                case 8:break;
                case 9:return;
                default: Console.WriteLine("Invalid choice");break;
                }

                displayOptions();
                choice = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
