using System;
using static System.Console;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static void miniMaxSum(int[] arr) 
    {
        // Complete this function
        var sumOfAllNumbers = 0L;
        var minimum = long.MaxValue;
        var maximum = 0L;
        
        for (int i = 0; i < 5; i++)
        {
            sumOfAllNumbers += arr[i];
            if (arr[i] < minimum)
                minimum = arr[i];

            if (arr[i] > maximum)
                maximum = arr[i];
        }
        WriteLine(string.Format("{0} {1}", sumOfAllNumbers - maximum, sumOfAllNumbers - minimum));
    }

    static void Main(String[] args) 
    {
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        miniMaxSum(arr);
    }
}