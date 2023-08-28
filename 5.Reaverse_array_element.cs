using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.reverse_array_element
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 5, 2, 8, 1, 9, 3 };

            Console.WriteLine("Original array:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nArray in reverse order:");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.ReadLine(); 
        }
    }
}
