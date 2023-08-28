using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Second_smallest_element_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 25, 8, 30, 15 };

            int secondSmallest = FindSecondSmallest(numbers);

            Console.WriteLine("The second smallest element in the array is: " + secondSmallest);

            Console.ReadLine();
        }

        static int FindSecondSmallest(int[] arr)
        {
            if (arr.Length < 2)
            {
                throw new InvalidOperationException("Array should have at least two elements.");
            }

            int smallest = Math.Min(arr[0], arr[1]);
            int secondSmallest = Math.Max(arr[0], arr[1]);

            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    secondSmallest = smallest;
                    smallest = arr[i];
                }
                else if (arr[i] < secondSmallest && arr[i] != smallest)
                {
                    secondSmallest = arr[i];
                }
            }

            return secondSmallest;
        }
    }
}
