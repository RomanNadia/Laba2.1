using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age:  ");
            int n = int.Parse(Console.ReadLine());
            int p = 0;
            if (n % 10 == 1 && n != 11)
            {
                p = 1;
            }
            else if ((n % 10 == 2 || n % 10 == 3 || n % 10 == 4) && (n != 12 || n != 13 || n != 14))
            {
                p = 2;
            }
            else if (n <= 100)
            {
                p = 3;
            }

            switch (p)
            {
                case 1: Console.WriteLine(n + " pik"); break;
                case 2: Console.WriteLine(n + " poku"); break;
                case 3: Console.WriteLine(n + " pokiB"); break;
            }

            }
        }
}
