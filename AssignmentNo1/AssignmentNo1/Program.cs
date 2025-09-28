using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;

            Console.WriteLine("Before swapping:");
            Console.WriteLine("num1 = " + num1 + ", num2 = " + num2);
            Swap(ref num1, ref num2);
            Console.WriteLine("After swapping:");
            Console.WriteLine("num1 = " + num1 + ", num2 = " + num2);
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
