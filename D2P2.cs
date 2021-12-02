using System;

namespace Advent
{
  class D2P2
  {
    public static void d2p2()
    {
      string[] text = System.IO.File.ReadAllLines(@"C:\Users\mindl\Documents\GitHub\Advent\Movement.txt");
      int horizontal = 0;
      int depth = 0;
      int aim = 0;

      foreach(string t in text){

          string[] temp = t.Split(" ");
          if (temp[0] == "forward"){
              horizontal += int.Parse(temp[1]);
              depth += int.Parse(temp[1]) * aim;
          }
          if(temp[0] == "down"){
              aim += int.Parse(temp[1]);
          }
          if(temp[0] == "up"){
              aim -= int.Parse(temp[1]);
          }

        }

        Console.WriteLine(horizontal * depth);
    }
  }
}