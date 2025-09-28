using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo1iii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            GetMaxMinAvg(num1, num2, out int max, out int min, out float avg);
            Console.WriteLine("Maximum = " + max);
            Console.WriteLine("Minimum = " + min);
            Console.WriteLine("Average = " + avg);
        }
        static void GetMaxMinAvg(int a, int b, out int max, out int min, out float avg)
        {
            max = (a > b) ? a : b;
            min = (a < b) ? a : b;
            avg = (a + b) / 2.0f;
        }
    }
}
