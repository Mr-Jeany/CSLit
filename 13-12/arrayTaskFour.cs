using System;
class HelloWorld
{
    static void Main()
    {
        var array = GenerateArray(10);
        PrintArray(array);
        var newArray = ClearArray(array);
        PrintArray(newArray);
    }
    
    static int[] ClearArray(int[] arr)
    {
        int counter = arr.Length;
        int empty = Int32.MinValue;
        for (int i = arr.Length-1; i > 0; i--)
        {
            if (arr[i] != empty && Count(arr, arr[i]) >= 2)
            {
                arr[i] = empty;
                counter--;
            }
        }
        
        int[] newArray = new int[counter];
        counter = 0;
        for (int i = 0; counter < newArray.Length; i++)
        {
            if (arr[i] != empty)
            {
                newArray[counter] = arr[i];
                counter++;
            }
        }
        
        return newArray;
        
    }
    
    static int Count(int[] arr, int toFind)
    {
        int counter = 0;
        foreach (var el in arr)
        {
            if (el == toFind)
            {
                counter++;
            }
        }
        return counter;
    }
    
    static void PrintArray(int[] arr)
    {
        Console.Write("{ ");
        foreach (var el in arr)
        {
            Console.Write(el + " ");
        }
        Console.WriteLine("}");
    }
    
    static int[] GenerateArray(int len)
    {
        int[] arr = new int[len];
        Random rnd = new Random();
        for (int el = 0; el < len; el++)
        {
            arr[el] = rnd.Next(10);
        }
        
        return arr;
    }
}
