/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
      Task4();
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
                  } else { Console.WriteLine("NOT FOUND!"); return; }
              }
          }
      }
  }
  
  static void Task3() {
      string text = Console.ReadLine();
      string[] words = text.Split();
      Console.WriteLine("The last word is \"" + words[words.Length-1] + "\". It's length is " + words[words.Length-1].Length);
  }
  
  static void Task4() {
      string text = Console.ReadLine();
      int number = int.Parse(text);
      
      int[] numbers = new int[text.Length];
      
      for (int i = 0; i < text.Length; i++) {
          numbers[i] = number % 10;
          number = number / 10;
      }
      
      string[] strNum = new string[numbers.Length];
      
      for (int i = 0; i < numbers.Length; i++) {
          strNum[i] = numbers[i].ToString();
      }
      
      for (int i = 0; i < numbers.Length; i++) {
          if (numbers[i] < 10) {
              if (numbers[i] <= 3 && numbers[i] >= 1) {
                  strNum[Array.IndexOf(strNum, numbers[i])] = MultStr("I", numbers[i]);
              } else if (4  <= numbers[i] && number <= 8) {
                  strNum[Array.IndexOf(strNum, numbers[i])] = "V" + MultStr("I", numbers[i]-5);
              } else {
                  
              }
          }
      }
  }
  
  static string MultStr(string str, int mult) {
      string tempStr = "";
      for (int n = 0; n < mult; n++) {
          tempStr = tempStr + str;
      }
      return tempStr;
  }
}
