using System;

namespace Lab2_05_01_
{
    class Program
    {
        static void Input1(out int n)
        {
            Console.Write("Enter number a i b =");
            n = int.Parse(Console.ReadLine());

        }
        static void Input2(int n, out int[,] a, out int[,] b)
        {
            a = new int[n, n];
            b = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Enter elemets of array a[{0}][{1}] = ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Enter elemets of array b[{0}][{1}] = ", i, j);
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void Output(int n, int[,] a)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", a[i, j]);

                }
                Console.Write("\n");
            }
        }
        static void Change(ref int[,] a, int[,] b, int n)
        {
            int[,] c = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((j) % 2 == 0)
                    {
                        c[i, j] = b[i, j];
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i) % 2 != 0)
                    {
                        a[i, j] = c[j, i - 1];
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int n;
            Input1(out n);
            Console.Write("\n");
            int[,] a = new int[n, n];
            int[,] b = new int[n, n];

            Input2(n, out a, out b);
            Console.WriteLine("\n array A with nxn elements : ");
            Output(n, a);

            Console.WriteLine("\n array B with nxn elements : ");
            Output(n, b);
            Console.WriteLine("\n new array");
            Change(ref a, b, n);
            Output(n, a);

        }
    }
}

