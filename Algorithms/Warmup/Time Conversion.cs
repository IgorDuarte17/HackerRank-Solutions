using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static string timeConversion(string s)
    {
        // Complete this function
        var amPm = s.Substring(8);
        var hourComponent = s.Substring(0, 2);
        var remainingTimeComponent = s.Substring(2, 6);

        if (amPm == "AM" && hourComponent == "12")
        {
            hourComponent = "00";
        }
        else if (amPm == "PM")
        {
            var numericHourComponent = int.Parse(hourComponent);
            if (numericHourComponent != 12)
            {
                hourComponent = Convert.ToString(12 + numericHourComponent);
            }
        }
        return hourComponent + remainingTimeComponent;
    }

    static void Main(String[] args) 
    {
        string s = Console.ReadLine();
        string result = timeConversion(s);
        Console.WriteLine(result);
    }
}
