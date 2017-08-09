using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        
        float positiveFraction = 0;
        float negativeFraction = 0;
        float zeroFraction = 0;
        
        foreach(int i in arr) {
            if(i > 0) {
                positiveFraction++;
            } else if (i < 0) {
                negativeFraction++;
            } else if (i == 0) {
                zeroFraction++;
            }
        }
            
            float positiveDecimal = positiveFraction / n;
            float negativeDecimal = negativeFraction / n;
            float zeroDecimal = zeroFraction / n;
            
            Console.WriteLine(positiveDecimal.ToString());
            Console.WriteLine(negativeDecimal.ToString());
            Console.WriteLine(zeroDecimal.ToString());
    }
}