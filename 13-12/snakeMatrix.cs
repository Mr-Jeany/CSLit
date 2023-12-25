using System;
class HelloWorld
{
    static void Main()
    {
        var array = GenerateSnake(5);
        PrintArray(array);
    }
    
    static int[,] GenerateSnake(int size)
    {
        int[,] newArr = new int[size,size];
        int counter = 1;
        for (int i = 0; i < size; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < size; j++)
                {
                    newArr[i, j] = counter;
                    counter++;
                }
            }
            else
            {
                for (int j = size - 1; j >= 0; j--)
                {
                    newArr[i, j] = counter;
                    counter++;
                }
            }
        }
        
        return newArr;
    }
    
    static void PrintArray(int[,] arr)
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
}
