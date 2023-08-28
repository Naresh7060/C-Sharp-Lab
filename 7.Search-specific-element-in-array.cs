using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Search_specific_element_in_array
{
    internal class Program
    {
            static void Main(string[] args)
            {
                int[] numbers = { 10, 25, 8, 30, 15 };
                int target = 30;

                int index = SearchValue(numbers, target);

                if (index != -1)
                {
                    Console.WriteLine("Value " + target + " found at index: " + index);
                }
                else
                {
                    Console.WriteLine("Value " + target + " not found in the array.");
                }
                Console.ReadLine();
            }

            static int SearchValue(int[] arr, int target)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == target)
                    {
                        return i; // Return the index where the value is found
                    }
                }

                return -1; // Return -1 if the value is not found
        }
    }
}
