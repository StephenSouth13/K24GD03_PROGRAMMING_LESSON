using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Enter the first number (a):");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number (b):");
            b = Convert.ToDouble(Console.ReadLine());

            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return;
            }
            else
            {
                Console.WriteLine("Calculating a / b...");
                c = a / b;
                Console.WriteLine($"The result of {a} / {b} is: {c}");
                Console.WriteLine("Calculation success.");
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}
