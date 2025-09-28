using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo5ii
{
    // Abstract base class
    abstract class Shape
    {
        public abstract double calc_area();
        public abstract double calc_volume();
    }

    // Sphere
    class Sphere : Shape
    {
        private double radius;

        public Sphere(double radius)
        {
            this.radius = radius;
        }

        public override double calc_area()
        {
            return 4 * Math.PI * radius * radius;
        }

        public override double calc_volume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }
    }

    // Cone
    class Cone : Shape
    {
        private double radius, height;

        public Cone(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override double calc_area()
        {
            double slant = Math.Sqrt(height * height + radius * radius);
            return Math.PI * radius * (radius + slant);
        }

        public override double calc_volume()
        {
            return (1.0 / 3.0) * Math.PI * radius * radius * height;
        }
    }

    // Cylinder
    class Cylinder : Shape
    {
        private double radius, height;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override double calc_area()
        {
            return 2 * Math.PI * radius * (radius + height);
        }

        public override double calc_volume()
        {
            return Math.PI * radius * radius * height;
        }
    }

    // Box (Cuboid)
    class Box : Shape
    {
        private double length, breadth, height;

        public Box(double length, double breadth, double height)
        {
            this.length = length;
            this.breadth = breadth;
            this.height = height;
        }

        public override double calc_area()
        {
            return 2 * (length * breadth + breadth * height + length * height);
        }

        public override double calc_volume()
        {
            return length * breadth * height;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sphere
            Sphere s = new Sphere(5);
            Console.WriteLine("Sphere -> Area: " + s.calc_area().ToString("F2") +
                              ", Volume: " + s.calc_volume().ToString("F2"));

            // Cone
            Cone c = new Cone(3, 7);
            Console.WriteLine("Cone -> Area: " + c.calc_area().ToString("F2") +
                              ", Volume: " + c.calc_volume().ToString("F2"));

            // Cylinder
            Cylinder cy = new Cylinder(4, 10);
            Console.WriteLine("Cylinder -> Area: " + cy.calc_area().ToString("F2") +
                              ", Volume: " + cy.calc_volume().ToString("F2"));

            // Box
            Box b = new Box(2, 3, 4);
            Console.WriteLine("Box -> Area: " + b.calc_area().ToString("F2") +
                              ", Volume: " + b.calc_volume().ToString("F2"));
        }
    }
}
