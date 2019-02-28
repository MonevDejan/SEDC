using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fill_the_matrix
{
    class Program
    {
        /* Write a program that fills and prints a matrix of size (n, n) as shown below.
         * On the second line you will receive a character (a, b, c, d*) which determines how to fill the matrix */

        static void PritnMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],3} ");
                }
                Console.WriteLine();
            }

        }

        static int[,] WriteMatrixa(int N)
        {
            int counter = 1;
            int[,] matrix = new int[N, N];
            for (int col = 0; col < N; col++)
            {
                for (int row = 0; row < N; row++)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }
            counter = 0;
            return matrix;
        }

        static int[,] WriteMatrixb(int N)
        {
            int counter = 1;
            int[,] matrix = new int[N, N];
            for (int i = 0; i < (N / 2) +1; i++)
            {
                if (matrix[N - 1, N - 1] != 0)
                {
                    break;
                }
                for (int row = 0; row < N; row++)
                {
                    matrix[row, 0 + 2 * i] = counter;
                    counter++;
                }
                if (matrix[N - 1, N - 1] != 0)
                {
                    break;
                }
                for (int row = N - 1; row >= 0; row--)
                {
                    matrix[row, 1 + 2 * i] = counter;
                    counter++;
                }
            }
            counter = 0;
            return matrix;
        }
        static int[,] WriteMatrixc(int N)
        {
            int counter = 1;
            int[,] matrix = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    matrix[(N - 1 - i) + j, 0 + j] = counter;
                    counter++;
                }
            }
            counter = N * N;
            for (int i = 0; i < N; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    matrix[0 + j, (N - 1 - i) + j] = counter;
                    counter--;
                }
            }
            counter = 0;
            return matrix;
        }
        static int[,] WriteMatrixd(int N)
        {
            int[,] matrix = new int[N, N];
            int counter = 1;
            bool check = true;

            for (int m = 0; m < N && check == true; m++)
            {
                for (int i = 0 + m; (i < N - m) && check == true; i++)
                {
                    if (matrix[0 + m, i] == 0)
                    {
                        matrix[0 + m, i] = counter;
                        counter++;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }
                for (int j = 1 + m; (j < N - m) && check == true; j++)
                {
                    if (matrix[j, N - 1 - m] == 0)
                    {
                        matrix[j, N - 1 - m] = counter;
                        counter++;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }
                for (int k = N - 2 - m; (k >= 0 + m) && check == true; k--)
                {
                    if (matrix[N - 1 - m, k] == 0)
                    {
                        matrix[N - 1 - m, k] = counter;
                        counter++;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }
                for (int l = N - 2 - m; (l > 0 + m) && check == true; l--)
                {
                    if (matrix[l, 0 + m] == 0)
                    {
                        matrix[l, 0 + m] = counter;
                        counter++;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }
            }
            counter = 0;
            return matrix;
        }
        static void Main()
        {
            Console.WriteLine("Enter dimension for matrix N*N, N= ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Chose way to print the matrix (a,b,c or d) ");
            char Way_to_print = char.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];

            if (Way_to_print == 'a')
            {
                matrix = WriteMatrixa(N);
                PritnMatrix(matrix);
            }
            if (Way_to_print == 'b')
            {
                matrix = WriteMatrixb(N);
                PritnMatrix(matrix);
            }
            if (Way_to_print == 'c')
            {
                matrix = WriteMatrixc(N);
                PritnMatrix(matrix);
            }
            if (Way_to_print == 'd')
            {
                matrix = WriteMatrixd(N);
                PritnMatrix(matrix);
            }
            Main();

        }
    }
}
