using System;

namespace Advent
{
  class D2P1
  {
    public static void d2p1()
    {
      string[] text = System.IO.File.ReadAllLines(@"C:\Users\mindl\Documents\GitHub\Advent\Movement.txt");
      int horizontal = 0;
      int depth = 0;

      foreach(string t in text){

          string[] temp = t.Split(" ");
          if (temp[0] == "forward"){
              horizontal += int.Parse(temp[1]);
          }
          if(temp[0] == "down"){
              depth += int.Parse(temp[1]);
          }
          if(temp[0] == "up"){
              depth -= int.Parse(temp[1]);
          }

        }

        Console.WriteLine(horizontal * depth);
    }
  }
}