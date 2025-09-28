using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo3ii
{
    // Define a delegate that takes a string and returns void
    public delegate void StringDelegate(string str);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Create a multicast delegate
            StringDelegate operations = Length;
            operations += ToUpperCase;
            operations += ToLowerCase;
            operations += ReverseString;

            // Call all methods through the multicast delegate
            operations(input);
        }

        // Method to print length of the string
        static void Length(string str)
        {
            Console.WriteLine("Length of string: " + str.Length);
        }

        // Method to convert string to uppercase
        static void ToUpperCase(string str)
        {
            Console.WriteLine("Uppercase: " + str.ToUpper());
        }

        // Method to convert string to lowercase
        static void ToLowerCase(string str)
        {
            Console.WriteLine("Lowercase: " + str.ToLower());
        }

        // Method to reverse the string
        static void ReverseString(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine("Reversed string: " + new string(chars));
        }
    }
}
