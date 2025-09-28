using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo7ii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create linked list with colors
            LinkedList<string> colors = new LinkedList<string>();
            colors.AddLast("red");
            colors.AddLast("blue");
            colors.AddLast("yellow");
            colors.AddLast("orange");

            Console.WriteLine("Original List:");
            foreach (string color in colors)
            {
                Console.Write(color + " ");
            }

            // (i) Display contents using iterator
            Console.WriteLine("\n\nList using Iterator:");
            IEnumerator<string> iterator = colors.GetEnumerator();
            while (iterator.MoveNext())
            {
                Console.Write(iterator.Current + " ");
            }

            // (ii) Display contents in reverse order
            Console.WriteLine("\n\nList in Reverse Order:");
            LinkedListNode<string> node = colors.Last;
            while (node != null)
            {
                Console.Write(node.Value + " ");
                node = node.Previous;
            }

            // (iii) Insert another list (pink, green) between blue and yellow
            LinkedList<string> newColors = new LinkedList<string>();
            newColors.AddLast("pink");
            newColors.AddLast("green");

            LinkedListNode<string> blueNode = colors.Find("blue");
            if (blueNode != null)
            {
                // Insert after blue
                foreach (string newColor in newColors)
                {
                    colors.AddAfter(blueNode, newColor);
                    blueNode = blueNode.Next; // move forward
                }
            }

            Console.WriteLine("\n\nList after inserting new colors:");
            foreach (string color in colors)
            {
                Console.Write(color + " ");
            }
        }
    }
}
