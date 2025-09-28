using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo5iii
{
    class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        // Default constructor
        public Fraction()
        {
            Numerator = 0;
            Denominator = 1;
        }

        // Parameterized constructor
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be zero.");

            Numerator = numerator;
            Denominator = denominator;
            Simplify();
        }

        // Method to display fraction
        public void Display()
        {
            Console.WriteLine($"{Numerator}/{Denominator}");
        }

        // Simplify fraction
        private void Simplify()
        {
            int gcd = GCD(Math.Abs(Numerator), Math.Abs(Denominator));
            Numerator /= gcd;
            Denominator /= gcd;

            // Handle negative denominator
            if (Denominator < 0)
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }
        }

        // GCD Helper Method
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Operator Overloading

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(
                a.Numerator * b.Denominator + b.Numerator * a.Denominator,
                a.Denominator * b.Denominator
            );
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction(
                a.Numerator * b.Denominator - b.Numerator * a.Denominator,
                a.Denominator * b.Denominator
            );
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(
                a.Numerator * b.Numerator,
                a.Denominator * b.Denominator
            );
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.Numerator == 0)
                throw new DivideByZeroException("Cannot divide by zero fraction.");

            return new Fraction(
                a.Numerator * b.Denominator,
                a.Denominator * b.Numerator
            );
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(1, 2);  // 1/2
            Fraction f2 = new Fraction(3, 4);  // 3/4

            Console.Write("f1 = "); f1.Display();
            Console.Write("f2 = "); f2.Display();

            Fraction sum = f1 + f2;
            Console.Write("f1 + f2 = "); sum.Display();

            Fraction diff = f1 - f2;
            Console.Write("f1 - f2 = "); diff.Display();

            Fraction product = f1 * f2;
            Console.Write("f1 * f2 = "); product.Display();

            Fraction quotient = f1 / f2;
            Console.Write("f1 / f2 = "); quotient.Display();
        }
    }
}
