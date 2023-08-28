﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Count_even_odd_element_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 25, 8, 30, 15 };
            int evenCount = 0;
            int oddCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            Console.WriteLine("Number of even elements: " + evenCount);
            Console.WriteLine("Number of odd elements: " + oddCount);

            Console.ReadLine();
        }
    }
}
