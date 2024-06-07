using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GitHubMainApplication
{
    public static class Insertion
    {
        public static void AddElement(int[] array, int count, int insertElement, int index)
        {
            count++;
            int elementAtIndex = array[index];
            array[index] = insertElement;
            int temporary;
            for (int iterator = index+1; iterator < count; iterator++)
            {
                temporary = array[iterator];
                array[iterator] = elementAtIndex;
                elementAtIndex = temporary;
               
            }
            for(int iterator = 0; iterator < count; iterator++)
            {
                Console.WriteLine(array[iterator]);
            }
        }
        public static void Insert(int[] array, int count)
        {
            if (count == array.Length)
            {
                Console.WriteLine("Array is full!! Delete some elements before inserting new elements");
                Console.ReadKey();
            }
            else
            {
                Console.Write("\nEnter the element to insert: ");
                int insertElement = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n----------------------------------------");
                Console.WriteLine("1. Insert element at beginning");
                Console.WriteLine("2. Insert element at a specified position");
                Console.WriteLine("3. Insert element at end");
                Console.WriteLine("----------------------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nSelect one option: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                int index;
                switch (choice)
                {
                    case 1:
                        index = 0;
                        AddElement(array, count, insertElement, index);
                        break;
                    case 2:
                        Console.Write("Enter the position to insert element: ");
                        index = Convert.ToInt32(Console.ReadLine()) - 1;
                        AddElement(array, count, insertElement, index);
                        break;
                    case 3:
                        index = count;
                        AddElement(array, count, insertElement, index);
                        break;
                    default:
                        Console.WriteLine("Please select a valid option");
                        break;

                }
            }
        }
    }
}
