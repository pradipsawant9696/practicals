using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo1ii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a floating-point number: ");
            float number = float.Parse(Console.ReadLine());
            Separate(number, out int integerPart, out float fractionalPart);
            Console.WriteLine("Integer part: " + integerPart);
            Console.WriteLine("Fractional part: " + fractionalPart);
        }
        static void Separate(float num, out int integerPart, out float fractionalPart)
        {
            integerPart = (int)num;
            fractionalPart = num - integerPart;
        }
    }
}
