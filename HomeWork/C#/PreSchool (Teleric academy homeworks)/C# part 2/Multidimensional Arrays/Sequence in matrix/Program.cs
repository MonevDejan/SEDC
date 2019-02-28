using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence_in_matrix
{
    class Program
    {
        public static void PritnMatrix(int[,] matrix)
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
        public static int HorizontalCheck(int[,] matrix, int row, int col)
        {
            int counter = 1;
            for (int index = 1; col + index < matrix.GetLength(1); index++)
            {
                if (matrix[row, col] == matrix[row, col + index])
                counter++;
                else break;
            }
            return counter;
        }
        public static int VerticalCheck(int[,] matrix, int row, int col)
        {
            int counter = 1;
            for (int index = 1; row +index < matrix.GetLength(0); index++)
            {
                if (matrix[row, col] == matrix[row + index, col])
                    counter++;
                else break;
            }
            return counter;
        }
        public static int Diagonal1Check(int[,] matrix, int row, int col)
        {
            int counter = 1;
            for (int index = 1; (row+index < matrix.GetLength(0)) && (col+index < matrix.GetLength(1)) ; index++)
            {
                if (matrix[row, col] == matrix[row + index, col+index])
                    counter++;
                else break;
            }
            return counter;
        }
        public static int Diagonal2Check(int[,] matrix, int row, int col)
        {
            int counter = 1;
            for (int index = 1; (row + index < matrix.GetLength(0)) && (col - index >= 0); index++)
            {
                if (matrix[row, col] == matrix[row + index, col - index])
                    counter++;
                else break;
            }
            return counter;
        }

        static void Main()
        {
            Console.WriteLine("Enter dimension for matrix N*M, N= M= ");
            string dimension = Console.ReadLine();
            int n = dimension.Split(' ').Select(int.Parse).First();
            int m = dimension.Split(' ').Select(int.Parse).Last();
            int[,] matrix = new int[n, m];
            int output = 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string values = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = values.Split(' ').Select(int.Parse).ElementAt(col);
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int hor = HorizontalCheck(matrix, row, col);
                    if (output < hor)
                    {
                        output = hor;
                    }
                    int ver = VerticalCheck(matrix, row, col);
                    if (output < ver)
                    {
                        output = ver;
                    }
                    int diagonal1 = Diagonal1Check(matrix, row, col);
                    if (output < diagonal1)
                    {
                        output = diagonal1;
                    }
                    int diagonal2 = Diagonal2Check(matrix, row, col);
                    if (output < diagonal2)
                    {
                        output = diagonal2;
                    }
                }
            }
            Console.WriteLine(output);
            Main();

        }
    }
}
