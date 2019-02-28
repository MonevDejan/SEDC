using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_array
{
    class Program
    {

        static int Printing(int value)
        {

            Console.WriteLine("First_Method");
            return value;
        }

        static int Printing(int value, int value2)
        {

            Console.WriteLine("Second_Method");
            return value;
        }


        static void Main()
        {
            bool[,] example = new bool[2, 3];
            bool[, , ] example1 = new bool[2,3, 3];
            bool[,,,] example12 = new bool[2, 3, 3, 5];
            int[,] matrix1 ={
                            {2,3,4 },
                            {1,1,1 }
                            };
            Console.WriteLine(matrix1.GetLength(0));
            Console.WriteLine();
            Console.WriteLine(matrix1.GetLength(1));
            Console.WriteLine();

            int[,,] matrisdx =
            {
                {
                {2,3,4,4 },
                {1,1,1,4 }
                },
                {
                {2,3,4 ,4},
                {1,7,5 ,4}
                },
                {
                {5,3,4,4 },
                {3,3,1 ,4}
                },
            };
            Console.WriteLine(matrisdx.GetLength(0));
            Console.WriteLine();
            Console.WriteLine(matrisdx.GetLength(1));
            Console.WriteLine();
            Console.WriteLine(matrisdx.GetLength(2));
            Console.WriteLine();
            const int name = 5;
            
             
        }
    }
}
