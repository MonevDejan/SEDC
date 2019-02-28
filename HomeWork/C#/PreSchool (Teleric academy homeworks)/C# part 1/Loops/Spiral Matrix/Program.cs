using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_of__numbers
{
    class Program
    {
        
        static void Main()
        {
            Console.WriteLine("Please enter number N=");
            int N = int.Parse(Console.ReadLine());

            if (1 <= N && N <= 20)
            {
                int[,] matrix = new int[N, N];
                int counter = 1;
                bool check = true;

                for (int m = 0; m < N && check == true; m++)
                {
                    for (int i = 0+m; (i < N-m) && check == true; i++)
                    {
                        if (matrix[0 + m, i] == 0)
                        {
                        matrix[0+m, i] =counter;
                        counter++;
                        }
                        else
                        {
                            check = false;
                            break;
                        }
                    }
                    for (int j = 1+m; (j < N-m) && check == true; j++)
                    {
                        if (matrix[j, N - 1 - m] == 0)
                        {
                        matrix[j, N-1-m] = counter;
                        counter++;
                        }
                        else
                        {
                            check = false;
                            break;
                        }
                    }
                    for (int k = N - 2-m; (k >= 0+m) && check == true; k--)
                    {
                        if (matrix[N - 1 - m, k] == 0)
                        {
                        matrix[N - 1-m, k] = counter;
                        counter++;
                        }
                        else
                        {
                            check = false;
                            break;
                        }
                    }
                    for (int l = N - 2-m; (l > 0+m) && check == true; l--)
                    {
                        if (matrix[l, 0 + m] == 0)
                        {
                        matrix[l, 0+m] = counter;
                        counter++;
                        }
                        else
                        {
                            check = false;
                            break;
                        }
                    }
                }
                for (int colum  = 0;  colum < N; colum++)
                {
                    for (int row = 0; row < N; row++)
                    {
                        Console.Write($"{matrix[colum,row],3} ");
                    }
                    Console.WriteLine();
                }
                
            }
            else
            {
                Console.WriteLine("Uhh Ohh");
            }
            Main();
        }
    }
}
