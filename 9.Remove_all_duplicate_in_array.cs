using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Remove_all_duplicate_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 16, 69, 8, 30, 39, 16, 69, 89 };

            int[] uniqueNumbers = RemoveDuplicates(numbers);

            Console.WriteLine("Array after removing duplicates:");
            PrintArray(uniqueNumbers);

            Console.ReadLine();
        }

        static int[] RemoveDuplicates(int[] arr)
        {
            HashSet<int> uniqueSet = new HashSet<int>();
            List<int> uniqueList = new List<int>();

            foreach (int num in arr)
            {
                if (!uniqueSet.Contains(num))
                {
                    uniqueSet.Add(num);
                    uniqueList.Add(num);
                }
            }

            return uniqueList.ToArray();
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
