using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubMainApplication
{
    public class SortOperation
    {

        int temperoryVariable,countOfElements;
        public SortOperation(int[] array,int count) {
            countOfElements=count;
            if (count != 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1.Ascending order\n2.Descending order");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        SortAscending(array);
                        break;
                    case 2:
                        SortDescending(array);
                        break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("array is empty");
            }

        }
        

        public  void SortAscending(int[] array) {
            for (int i = 0; i < countOfElements; i++)
            {
                for (int j = 0; j <countOfElements; j++)
                {
                    if (array[i] < array[j])
                    {
                        temperoryVariable = array[i];
                        array[i] = array[j];
                        array[j] = temperoryVariable;
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Array after sorting in Ascending order :");
            for (int i = 0; i <countOfElements; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        public void SortDescending(int[] array) {
            for (int i = 0; i <countOfElements; i++)
            {
                for (int j = 0; j <countOfElements; j++)
                {
                    if (array[i] > array[j])
                    {
                        temperoryVariable = array[i];
                        array[i] = array[j];
                        array[j] = temperoryVariable;
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Array after sorting in Descending order :");
            for (int i = 0; i <countOfElements; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
