using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximal_sum
{
    class Program
    {
        //Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements. Print that sum.
        static int[,] WriteMatrix(int N, int M, int [] values)
        {
            int counter = 0;
            int[,] matrix = new int[N, M];
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < M; col++)
                {
                    matrix[row, col] = values[counter];
                    counter++;
                }
            }
            counter = 0;
            return matrix;
        }
        static void Main()
        {
            Console.WriteLine("Enter dimension for matrix N*M, N= M= ");
            string Dimension = Console.ReadLine();
            int N = Dimension.Split(' ').Select(int.Parse).First();
            int M = Dimension.Split(' ').Select(int.Parse).Last();

            if (N >2 && M >2)
            {
                Console.WriteLine("Please enter the values for the matrix");
                string values = Console.ReadLine();
                int[] elements = values.Split(' ').Select(int.Parse).ToArray();
                int[,] matrix = WriteMatrix(N, M, elements);
                int sum = 0;
                int check = 0;

                for (int i = 0; i < matrix.GetLength(0) - 2; i++)
                {
                    for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                    {
                        for (int row = i; row < 3 + i; row++)
                        {
                            for (int col = j; col < 3 + j; col++)
                            {
                                check += matrix[row, col];
                            }
                        }
                        if (check > sum)
                        {
                            sum = check;
                        }
                        check = 0;
                    }
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("you entered wrong number");
            }
            
        }
    }
}
