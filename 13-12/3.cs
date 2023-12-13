using System;

namespace _13_12_3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteStup(Clear(CreateStup()));
        }

        static int[][] CreateStup()
        {
            Console.Write("size: ");
            int size = int.Parse(Console.ReadLine());
            int[][] arr = new int[size][];
            
            for (int i = 0; i < size; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                arr[i] = new int[input.Length];
                for (int j = 0; j < input.Length; j++)
                {
                    arr[i][j] = int.Parse(input[j]);
                }
            }

            return arr;
        }
        
        static void WriteStup(int[][] arr)
        {
            foreach (var el in arr)
            {
                foreach (var val in el)
                {
                    Console.Write(val+" ");
                }
                
                Console.WriteLine();
            }
        }

        static int[][] Clear(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] % 2 == 0)
                    {
                        arr[i][j] = i * j;
                    }
                }
            }

            return arr;
        }
    }
}
