using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubMainApplication
{
    public class SortOperation
    {
        public SortOperation(int[] array) {
            if (array.Length != 0)
            {
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
                Console.WriteLine("array is empty");
            }

        }
        int temperoryVariable,count=1;

        public  void SortAscending(int[] array) {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        temperoryVariable = array[i];
                        array[i] = array[j];
                        array[j] = temperoryVariable;
                    }
                }
            }

            Console.WriteLine("Array after sorting in Ascending order :");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        public void SortDescending(int[] array) {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temperoryVariable = array[i];
                        array[i] = array[j];
                        array[j] = temperoryVariable;
                    }
                }
            }
            Console.WriteLine("Array after sorting in Descending order :");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
