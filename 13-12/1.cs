using System;

namespace _13_12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 102, 56, -56, -180, 78};
            PrintArray(Clear(arr));
        }

        static float Middle(int[] arr)
        {
            float summ = 0;

            foreach (var num in arr)
            {
                summ += (float)num;
            }

            return summ / (float)(arr.Length);
        }

        static int[] Clear(int[] arr)
        {
            int counter = 0;
            foreach (var el in arr)
            {
                if (el <= 100 && el >= -100)
                {
                    counter++;
                }
            }

            int[] newArray = new int[counter];

            int indexCounter = 0;
            foreach (var el in arr)
            {
                if (el <= 100 && el >= -100)
                {
                    newArray[indexCounter] = el;
                    indexCounter++;
                }
            }

            return newArray;
        }
        
        static void PrintArray(int[] arr)
        {
            foreach (var el in arr)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }
    }
}
