using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuisDay3Array
{
    internal class Matrix
    {

        public static int[,] FillRandomMatrix(int b,int c)
        {
            int[,] matrix = new int[b,c];
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++) //Baris
            {
                for (int j = 0; j < matrix.GetLength(1); j++) //Colom
                {
                    matrix[i, j] = random.Next(0, 20);
                }
                
            }


            return matrix;
        }
        public static void DisplayMatriks(int [,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        public static int[,] MatrixDiagonal(int b,int c)
        {
            int [,] matrix = new int[b,c];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = 0;
                    }
                    else if(j>i)
                        {
                        matrix[i, j] = 10;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 20;
                    }
                }
            }
            return matrix;
                
        }

        public static void InitMatriks()
        {
            int[,] matriks = new int[5,5];
            matriks[2, 2] = 125;
        }
    }
}
