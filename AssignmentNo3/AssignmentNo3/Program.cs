using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo3
{
    // Define the delegate type
    public delegate int MyDelegate(int n);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            // Delegate pointing to Prime method
            MyDelegate primeDelegate = new MyDelegate(Prime);
            int isPrime = primeDelegate(num);
            Console.WriteLine(isPrime == 1 ? "Prime number" : "Not a prime number");

            // Delegate pointing to Reverse method
            MyDelegate reverseDelegate = new MyDelegate(Reverse);
            int reversed = reverseDelegate(num);
            Console.WriteLine("Reversed number: " + reversed);

            // Delegate pointing to Sum_Digit method
            MyDelegate sumDelegate = new MyDelegate(Sum_Digit);
            int sum = sumDelegate(num);
            Console.WriteLine("Sum of digits: " + sum);

            // Delegate pointing to Fact method
            MyDelegate factDelegate = new MyDelegate(Fact);
            int factorial = factDelegate(num);
            Console.WriteLine("Factorial: " + factorial);
        }

         // Method to check if number is prime
    static int Prime(int n)
    {
        if (n <= 1) return 0;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return 0;
        }
        return 1;
    }

    // Method to reverse the digits of number
    static int Reverse(int n)
    {
        int rev = 0;
        while (n > 0)
        {
            rev = rev * 10 + n % 10;
            n /= 10;
        }
        return rev;
    }

    // Method to sum the digits of number
    static int Sum_Digit(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }

    // Method to find factorial
    static int Fact(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        int fact = 1;
        for (int i = 2; i <= n; i++)
        {
            fact *= i;
        }
        return fact;
    }
    }
}
