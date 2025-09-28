using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo1v
{
    internal class Program
    {
        static void Main(string[] args)
        {
            greetings("Welcome", "Yash", "Saif", "Abhi");
        }
        static void greetings(string msg, params string[] students)
        {
            foreach (string student in students)
            {
                Console.WriteLine(msg + ", " + student + "!");
            }
        }
    }
}
