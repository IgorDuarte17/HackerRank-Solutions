using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        
          for (int i = 0; i < n; i++) {
            Console.WriteLine(new String('#', i + 1).PadLeft(n, ' '));
          }
    }
}