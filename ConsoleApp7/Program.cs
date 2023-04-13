using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    //Print alternate number from an array.
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Alternate numbers from the array are:");
            for (int i = 0; i < numbers.Length; i += 2)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }

}
    

