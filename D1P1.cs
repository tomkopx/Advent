using System;

namespace Advent
{
  class D1P1
  {
    public static void d1p1()
    {
      int answer = 0;
      int iterator = 0;
      string[] text = System.IO.File.ReadAllLines(@"C:\Users\mindl\Documents\GitHub\Advent\Depth.txt");
      int[] num = Array.ConvertAll(text, s => int.Parse(s));
  
      foreach(int i in num){
        
        if(iterator == 0){
          iterator++;
        }
        else if(i > num[iterator - 1]){
          answer++;
          iterator++;
        }
        else{
          iterator++;
        }
      }
      Console.WriteLine(answer);
    }
  }
}