using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo1iv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = FindMin(5, 3, 8, 1, 6);
            Console.WriteLine("Minimum number is: " + min);
        }

        static int FindMin(params int[] numbers)
        {
            int min = numbers[0];
            foreach (int num in numbers)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }
    }
}
