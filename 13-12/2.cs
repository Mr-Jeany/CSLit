using System;

namespace _13_12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = BestCreate2D();
            Console.WriteLine();
            Print2D(arr);
        }

        static void Print2D(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[,] Create2D()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int[,] arr = new int[x, y];
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return arr;
        }

        static int[,] BetterCreate2D()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int[,] arr = new int[x, y];
            
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                string[] inp = Console.ReadLine().Split(" ");
                for (int j = 0; j < inp.Length; j++)
                {
                    arr[i, j] = int.Parse(inp[j]);
                }
            }

            return arr;
        }

        static int[,] BestCreate2D()
        {
            string input1 = Console.ReadLine();
            int size = input1.Split(" ").Length;
            int[,] arr = new int[size, size];
            
            for (int i = 0; i < input1.Split(" ").Length; i++)
            {
                arr[0, i] = int.Parse(input1.Split(" ")[i]);
            }

            for (int i = 1; i < size; i++)
            {
                input1 = Console.ReadLine();
                for (int j = 0; j < input1.Split(" ").Length; j++)
                {
                    arr[i, j] = int.Parse(input1.Split(" ")[j]);
                }
            }

            return arr;

        }
    }
}
