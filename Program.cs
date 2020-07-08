using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Swap (ref int a, ref int b)
        {
            a = a - b;
            b = a + b;
            a = b - a;
        }

        static void PrintSquares(int n)
        {
            var i = 0;
            var cumulativeSquare = 0;
            Console.WriteLine(cumulativeSquare);
            while (i < n)
            {
                cumulativeSquare = cumulativeSquare + i + i + 1;
                i++;
                Console.WriteLine(cumulativeSquare);
            }
        }

        static int Nod(int a, int b)
        {
            return b == 0 ? a : Nod(b, a % b);
        }

        static void Main(string[] args)
        {
        }
    }
}
