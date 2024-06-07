using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubMainApplication
{
    internal class DeletionOperation
    {
        public static void Deletion(int[] array, int count)
        {
            Console.WriteLine("");
            if (count != 0)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("-----------------------MENU-------------------------");
                Console.WriteLine("1. Delete the first element");
                Console.WriteLine("2. Delete an element from specific position");
                Console.WriteLine("3. Delete the last element");
                Console.ForegroundColor = ConsoleColor.White;
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                switch (choice)
                {
                    case 1:
                        DeleteElement(array, count, 1);
                        break;
                    case 2:
                        Console.WriteLine("What position do you want to delete elements from?");
                        int position = Convert.ToInt32(Console.ReadLine());
                        DeleteElement(array, count, position);
                        break;
                    case 3:
                        DeleteElement(array, count, count);
                        break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Array empty!! No elements to delete");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("");
        }

        public static void DeleteElement(int[] array, int count, int position)
        {
            for (int index = position; index < count; index++)
            {
                array[index - 1] = array[index];
            }
            count--;
            Console.WriteLine("Print the updated array:");
            for (int index = 0; index < count; index++)
            {
                Console.Write(array[index] + " ");
            }
            
        }
    }
}
