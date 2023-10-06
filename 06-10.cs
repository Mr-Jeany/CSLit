/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
      Task2();
  }
  
  static void Task2() {
      bool fi = int.TryParse(Console.ReadLine(), out int howm);
      bool found = false;
      
      
      if (!fi || howm <= 0) {
          Console.WriteLine("INCORRECT NUMBER OR NOT A NUMBER");
          return;
      } else {
          int[] numbers = new int[howm];
          for (int i = 0; i < howm; i++) {
              bool ni = int.TryParse(Console.ReadLine(), out int num);
              if (!ni) {
                  Console.WriteLine("NOT A NUMBER");
                  return;
              } else {
                  numbers[i] = num;
              }
          }
          
          bool fn = int.TryParse(Console.ReadLine(), out int toFind);
          
          if (!fn) {
              Console.WriteLine("NOT A NUMBER");
              return;
          } else {
              for (int n = 0; n < numbers.Length; n++) {
                  if (!found && numbers[n] < toFind) {
                      for (int k = 0; k < numbers.Length; k++) {
                          if (numbers[k]+numbers[n] == toFind) {
                              found = true;
                              Console.Write(n + " ");
                              Console.WriteLine(k);
                              return;
                          }
                      }
                  }
              }
          }
      }
  }
}
