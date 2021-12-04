using System;
using System.Text;

namespace Advent
{
  class D3P1
  {
    public static void d3p1(){

        
        int[] one = new int[12];
        int[] zero = new int[12];
        StringBuilder gamma = new StringBuilder();
        StringBuilder epsilon = new StringBuilder();
        

        foreach (string l in System.IO.File.ReadLines(@"C:\Users\mindl\Documents\GitHub\Advent\Diagnostic.txt")){

            for(int i = 0; i < 12; i++){
                if(l[i].Equals('0')){
                    zero[i]++;
                }
                else{
                    one[i]++;
                }
            }

            

        }

        for(int i = 0; i < 12; i++){
            if(one[i] > zero[i]){
                gamma.Append("1");
                epsilon.Append("0");
            }
            else{
                gamma.Append("0");
                epsilon.Append("1");
            }
        }


        Console.WriteLine(gamma);
        Console.WriteLine(epsilon);

        int finalGamma = ConvertClass.Convert(gamma.ToString());
        int finalEpsilon = ConvertClass.Convert(epsilon.ToString());

        Console.WriteLine(finalGamma);
        Console.WriteLine(finalEpsilon);

        Console.WriteLine(finalGamma * finalEpsilon);
    

    }
  }
}