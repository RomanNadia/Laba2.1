using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|  X:  | Y=f(x): |");
            double a = 0, b = 3, dx = 0.05, y, x = a;
            while (x <= b)
            {
                y = Math.Pow(4, -Math.Cos(x));
                y = Math.Round(y, 4);
                Console.WriteLine("| {0,-4} | {1,-7} |", x, y);
                x += dx;
                x = Math.Round(x, 2);

            }
        }
    }
}
