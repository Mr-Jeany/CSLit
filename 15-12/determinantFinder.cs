using System;

namespace _15_12_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 4]
            {
                {1, 2, 4, 3},
                {6, 7, 3, 2},
                {9, 1, 5, -2},
                {-6, 3, 8, 9},
            };
            
            Console.WriteLine(Determinant(matrix));
        }

        static int Determinant(int[,] matr)
        {
            int size = matr.GetLength(0);
            int determ = 0;

            if (size == 2)
            {
                determ += matr[0, 0] * matr[1, 1] - matr[0, 1] * matr[1, 0];
                
            } 
            else if (size == 1)
            {
                return matr[0, 0];
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    int det = Determinant(CutMatrix(matr, i, 0));
                    int sign = i % 2  == 0? 1 : -1;
                    determ += (sign) * matr[0, i] * det;
                    
                }
            }

            return determ;
        }

        static int[,] CutMatrix(int[,] firstMatrix, int x, int y)
        {
            int size = firstMatrix.GetLength(0);
            int[,] matrix = new int[size - 1, size - 1];
            int counterX = 0;
            int counterY = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (counterX == size-1)
                    {
                        counterX = 0;
                        counterY++;
                    }
                    if (i != x && j != y)
                    {
                        matrix[counterX, counterY] = firstMatrix[j, i];
                        counterX++;
                    }
                }
            }
            
            return matrix;
        }
        
        static void WriteMatrix(int[,] matr)
        {
            int size = matr.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
