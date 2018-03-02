using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static int birthdayCakeCandles(int n, int[] ar)
    {
        // Complete this function
        var maxValue = ar[0];
        var maxValueOccurence = 1;
        
        for (int i = 1; i < ar.Length; i++)
        {
            if (ar[i] == maxValue)
            {
                maxValueOccurence++;
                continue;
            }
            if (ar[i] > maxValue)
            {
                maxValue = ar[i];
                maxValueOccurence = 1;
            }
        }
        return maxValueOccurence;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = birthdayCakeCandles(n, ar);
        Console.WriteLine(result);
    }
}