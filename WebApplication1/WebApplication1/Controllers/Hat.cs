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

class Result
{

    /*
     * Complete the 'stringSimilarity' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int stringSimilarity(string a)
    {
        int[] Z = new int[a.Length];
        int L, R, k;
        Z[0] = a.Length;

        L = R = 0;

        for (int i = 1; i < a.Length; i++)
        {
            if (i > R)
            {
                L = R = i;
                while (R < a.Length && a[R] == a[R - L])
                    R++;
                Z[i] = R - L;
                R--; //sets it back to the end of the similarity
            }
            else
            {
                k = i - L;
                if (Z[k] < R - i + 1)
                    Z[i] = Z[k];
                else
                {
                    L = i;
                    while (R < a.Length && a[R] == a[R - L])
                        R++;
                    Z[i] = R - L;
                    R--;
                }
            }
        }

        int sum = 0;
        foreach (int num in Z)
            sum += num;
        return sum;
    }

    public static void virusIndices(string p, string v)
    {
        // Print the answer for this test case in a single line
        var trace = new int[p.Length, v.Length, 2];
        trace[0, 0, 0] = v[0] == p[0] ? 1 : 0;
        trace[0, 0, 1] = 1;
        for (int i = 0; i < p.Length; i = i + 1)
        {
            for (int j = 0; j < v.Length; j++)
            {
                if (v[j] == p[i])
                {
                    if (j == 0 || i == 0)
                    {
                        trace[i, j, 0] = 1;
                        trace[i, j, 1] = 1;
                    }
                    else
                    {
                        trace[i, j, 0] = Math.Max(trace[i - 1, j, 0], trace[i, j - 1, 0]) + 1;
                        trace[i, j, 1] = Math.Max(trace[i - 1, j, 1], trace[i, j - 1, 1]) + 1;
                    }

                }
                else
                {
                    trace[i, j, 0] = 0;
                    if (j == 0 || i == 0)
                    {
                        trace[i, j, 1] = 1;
                    }
                    else
                    {
                        trace[i, j, 1] = Math.Max(trace[i - 1, j, 0], trace[i, j - 1, 0]) + 1;

                    }
                }
            }
        }

        var total = "";
        for (int i = v.Length; i < p.Length; i = i + 1)
        {
            var j = v.Length - 1;
            if (trace[i, j, 0] == v.Length)
            {
                total += i - j;

            }
            else if (trace[i, j, 1] == v.Length)
            {
                total += i - j;

            }
        }

        Console.WriteLine("No Match!");

    }


}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string s = Console.ReadLine();

            int result = Result.stringSimilarity(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
