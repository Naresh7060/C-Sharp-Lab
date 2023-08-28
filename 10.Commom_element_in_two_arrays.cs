using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Commom_element_in_two_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 17, 25, 7, 26, 47 };
            int[] array2 = { 7, 26, 40, 17 };

            int[] commonElements = FindCommonElements(array1, array2);

            Console.WriteLine("Common elements in the arrays:");
            PrintArray(commonElements);

            Console.ReadLine();
        }

        static int[] FindCommonElements(int[] arr1, int[] arr2)
        {
            HashSet<int> set1 = new HashSet<int>(arr1);
            HashSet<int> commonSet = new HashSet<int>();

            foreach (int num in arr2)
            {
                if (set1.Contains(num))
                {
                    commonSet.Add(num);
                }
            }

            return commonSet.ToArray();
        }

        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
