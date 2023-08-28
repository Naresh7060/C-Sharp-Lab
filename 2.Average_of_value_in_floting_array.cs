using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Average_of_value_in_floting_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] values = { 10.5f, 20.3f, 15.7f, 8.2f, 12.9f };
            float sum = 0;

            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            float average = sum / values.Length;

            Console.WriteLine("The average of the values array: " + average);

            Console.ReadLine();
        }
    }
    
}
