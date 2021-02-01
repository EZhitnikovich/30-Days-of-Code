using System.CodeDom.Compiler;
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

class Solution
{



    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            Console.WriteLine(FindMax(n, k));
        }
    }

    static int FindMax(int n, int k)
    {
        var range = Enumerable.Range(1, n);

        int max = int.MinValue;

        for(int i = 0; i<n-1; i++)
        {
            int temp = range.ElementAt(i);
            for(int j=i+1; j<n; j++)
            {
                int bAnd = temp & range.ElementAt(j);
                if (max < bAnd && bAnd < k)
                    max = bAnd;
            }
        }

        return max;
    }
}
