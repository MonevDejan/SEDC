using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_of_numbers__Advanced_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers N=");
            int N = int.Parse(Console.ReadLine());

            if (1 <= N && N <= 20)
            {
                for (int i = 1, j=1; i <= N + N - 1; i++, j++)
                {
                    Console.Write("{0, 2}", i);
                    if (i==N+N-1)
                    {
                        break;
                    }
                    if (j==N)
                    {
                        Console.WriteLine();
                        j = 0;
                        i = i - (N - 1);
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Uhh Ohh");
            }
        }
    }
}
                /*for (int i = 1, j = 0, k = N + (N - 1), l = N; i <= N; i++, j++, k--, l--)
                {

                    Console.SetCursorPosition(i + j - 1, 4);
                    Console.Write(i);
                    Console.SetCursorPosition(0, i + 3);
                    Console.Write(i);
                    Console.SetCursorPosition(2 * l - 2, N + 3);
                    Console.Write(k);
                    Console.SetCursorPosition(2 * N - 2, N + 4 - i);
                    Console.Write(k);

                    Console.SetCursorPosition(i - 1 + j, i - 1 + 4);
                    Console.Write(i + j);
                    Console.SetCursorPosition(2 * N - 2 - 2 * j, i - 1 + 4);
                    Console.Write(N);
                }
                Console.SetCursorPosition(0, 25);
                Console.WriteLine(); */
