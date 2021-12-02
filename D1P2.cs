using System;
using System.Linq;

namespace Advent
{
  class D1P2
  {
    public static void d1p2()
    {
      int answer = 0;
      string[] text = System.IO.File.ReadAllLines(@"C:\Users\mindl\Documents\GitHub\Advent\Depth.txt");
      int[] num = Array.ConvertAll(text, s => int.Parse(s));
      List<int> sum = new List<int>();

      for (int i = 0; i < 1998; i++){
        sum.Add(num[i] + num[i+1] + num[i+2]);
      }

      for (int j = 0; j < sum.Count; j++){

        if(j != 0 && sum[j] > sum[j-1]){
            answer++;
        }
      }

      Console.WriteLine(answer);
    }
  }
}