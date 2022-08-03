﻿    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Serialization;
    using System.Text.RegularExpressions;
    using System.Text;
    using System;

namespace hackerrank
{

    class Result
    {

        /*
        * Complete the 'miniMaxSum' function below.
        *
        * The function accepts INTEGER_ARRAY arr as parameter.
        */

        public static void miniMaxSum(List<int> arr)
        {
            int iMin = arr.Min();
            int iMax = arr.Max();
            int iSum = 0;
            Console.WriteLine($"Min: {iMin}, Max {iMax}");

            foreach (var index in arr)
            {
                foreach (var item in arr)
                {
                    if(item == iMin){
                        // do nothing
                    }else if(item == iMax){
                        // do nothing
                    }else{
                        iSum += item;
                    }
                }
            }

           
            Console.WriteLine($"Sum: {iSum}");
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a integer array seperated by spaces");
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.miniMaxSum(arr);
        }
    }
}
