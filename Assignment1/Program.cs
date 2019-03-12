using System;
using System.Linq;

namespace Assignment1_S19
{
    class Program
    {
        public static void Main()
        {
            int a = 5, b = 15;
            printPrimeNumbers(a, b);

            Console.ReadKey();

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);

            Console.ReadKey();

            int n4 = 5;
            printTriangle(n4);

            Console.ReadKey();
            
            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);

            Console.ReadKey();
        }
        //Question 1
        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                Console.WriteLine("Prime numbers are the following: ");
                int i, j;
                for (i = x; i <= y; i++)
                {
                    bool isPrime = true;
                    for (j = 2; j <= y; j++)
                    {
                        if (i != j && i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        Console.WriteLine("\t" + i);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }
        //Question 2
        public static double getSeriesResult(int n)
        {
            try
            {
                int i;
                double sum, r;
                sum = 0;
                for (i = 1; i <= n; i++)
                {
                    r = (Math.Pow((-1), (i + 1)) * Factorial(i)) / (i + 1);
                    sum = sum + r;
                }
                return Math.Round(sum, 3);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }
            return 0;
        }
        //Helper function for factorials
        public static double Factorial(int n)
        {
            int i;
            int f = 1;
            for (i = 1; i <= n; i++)
            {
                f = f * i;
            }
            return f;
        }
        //Question 3
        public static void printTriangle(int n)
        {
            try
            {
                int i, row, spc, brk;
                row = 0;
                for (i = 1; i <= n; i++)
                {
                    for (spc = i + 1; spc <= n + 1; spc++)
                    {
                        Console.Write(" ");
                    }
                    for (row = 0; row < 2 * i - 1; row++)
                    {
                        Console.Write("*");
                    }
                    for (brk = 1; brk < 2; brk++)
                    {
                        Console.Write("\n");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured whilec omputing printTriangle()");

            }
        }
        //Question 4
        public static void computeFrequency(int[] a)
        {
            try
            {
                int[] arr = new int[10];
                int i, j;

                for (i = 0; i < 10; i++)
                {
                    for (j = 0; j < a.Length; j++)
                    {
                        if (a[j] == i)
                            arr[i]++;
                    }
                }

                Console.WriteLine("Number " + "Frequency");

                for (i = 0; i < 10; i++)
                {
                    if (arr[i] > 0)
                    {
                        Console.WriteLine(i + "      " + arr[i]);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
    }
}
