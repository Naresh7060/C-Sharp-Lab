﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Largest_element_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 25, 5, 30, 15 };
            int largest = numbers[0]; // Initialize with the first element

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }

            Console.WriteLine("The largest element in the array is: " + largest);

            Console.ReadLine();
        }
    }
}
