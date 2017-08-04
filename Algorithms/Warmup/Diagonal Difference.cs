using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {

        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];

        for (int i = 0; i < n; i++) {
            string[] temp = Console.ReadLine().Split(' ');
            a[i] = Array.ConvertAll(temp,Int32.Parse);
        }
        
        int diagonal1 = 0;
        int diagonal2 = 0;

        for (int i=0; i<n; i++) {
            diagonal1 += a[i][i];
            diagonal2 += a[i][n-1-i];
        }
        Console.WriteLine(Math.Abs(diagonal1 - diagonal2));
    }
}
