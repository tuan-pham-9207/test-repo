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
using System.Diagnostics;

class HackerRank
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

    public static void virusIndices1(string p, string v)
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

    public static void virusIndices(string p, string v)
    {
        // Print the answer for this test case in a single line
        var trace = new (int, bool)[p.Length, v.Length];
        Console.WriteLine($"start v: {v.Length}   ;  p: {p.Length}");
        var stopWatch = new Stopwatch();
        stopWatch.Start();
        for (var i = 0; i < p.Length - v.Length; i = i + 1)
        {
            for (var j = 0; j < v.Length; j++)
            {
            }
        }
        stopWatch.Stop();
        Console.WriteLine($"Stop time {stopWatch.Elapsed}");

        stopWatch.Restart();
        var results = new List<int>();
        for (var i = 0; i < p.Length - v.Length; i = i + 1)
        {
            for (var j = 0; j < v.Length; j++)
            {
                if (v[j] == p[i])
                {
                    if (j == 0 || i == 0)
                    {
                        trace[i, j] = (1, false);
                    }
                    else
                    {
                        var item = trace[i - 1, j - 1];
                        trace[i, j] = (item.Item1 + 1, item.Item2);

                    }

                    //if (trace[i, j].Item1 == v.Length)
                    //{
                    //    results.Add(i - v.Length + 1);
                    //}

                }
                else
                {
                    if (j > 0 && i > 0)
                    {
                        var item = trace[i - 1, j - 1];
                        if (!item.Item2)
                        {
                            trace[i, j] = (item.Item1 + 1, true);
                        }
                        else
                        {
                            trace[i, j] = (1, true);
                        }
                    }
                    else
                    {
                        trace[i, j] = (1, true);
                    }

                    //if (trace[i, j].Item1 == v.Length)
                    //{
                    //    results.Add(i - v.Length + 1);
                    //}

                }

            }
        }

        stopWatch.Stop();
        Console.WriteLine($"Stop time in calculate {stopWatch.Elapsed}");
        if (results.Any())
        {
            Console.WriteLine(string.Join(" ", results.OrderBy(m => m)));
        }
        else
        {
            Console.WriteLine("No Match!");

        }

    }

    public static int buildString(int a, int b, string s)
    {
        var left = "";

        string FindSubString(string subStr, string origin)
        {
            int i, j;
            i = j = 0;
            var similar = new int[subStr.Length, origin.Length];
            (int posSub, int posOrigin, int total) max = (0, 0, 0);
            for (int k = 0; k < subStr.Length; k++)
            {
                var l = 0;
                var m = k;
                while (l < origin.Length && m < subStr.Length && origin[l] == subStr[m])
                {
                    l++;
                    m++;
                }

                if (max.total < l)
                {
                    max = (0, 0, l);
                }
                //for (int l = 0; l < origin.Length; l++)
                //{
                //    if (subStr[k] == origin[l])
                //    {
                //        if (k == 0 || l == 0)
                //        {
                //            similar[k, l] = 1;
                //        }
                //        else
                //        {
                //            similar[k, l] = similar[k - 1, l - 1] + 1;
                //        }

                //        if (max.total < similar[k, l])
                //        {
                //            max = (k, l, similar[k, l]);
                //        }
                //    }
                //    else
                //    {
                //        //if (similar[k, l - 1].Length > similar[k - 1, l].Length)
                //        //{
                //        //    similar[k, l]=
                //        //}
                //        //similar[k, l] = similar[k, l - 1] + s[k];
                //       break;
                //    }


                //}
            }

            var sub = "";
            if (max.total > 0)
            {
                sub = origin.Substring(max.posOrigin, max.total);

            }
            Console.WriteLine($"detail common  {max}, {sub}");
            Console.WriteLine($"{origin}");
            Console.WriteLine($"{subStr}");
            Console.WriteLine(sub);
            Console.WriteLine();
            return sub;

        }

        var total = 0;
        var origin = s;
        while (0 < s.Length)
        {
            var commonStr = FindSubString(left, s);
            if (string.IsNullOrWhiteSpace(commonStr))
            {
                commonStr = s[0].ToString();
            }

            var commonCost = commonStr.Length * a;
            var added = commonCost < b ? commonCost : b;

            if (commonStr.Length * a < b)
            {
                commonStr = s[0].ToString();

                total += commonStr.Length * a;
            }
            else
            {
                total += b;
            }
            left += commonStr;
            Console.WriteLine($"origin:  {origin}, common: {commonStr} ,left: {left},before: {s}, {added}, {total}");

            s = s.Substring(commonStr.Length);
        }
        Console.WriteLine($"Total {total}");
        return total;
    }
    public static int insertionSort(List<int> arr)
    {
        var sortArr = arr;
        var stopwatch = Stopwatch.StartNew();
        for (int i = 0; i < 10_000; i++)
        {
            for (int j = 0; j < 10_000; j++)
            {

            }
        }
        stopwatch.Stop();
        Console.WriteLine($"Total {stopwatch.Elapsed}");

        for (var i = 0; i < arr.Count; i++)
        {
            var index = sortArr.IndexOf(arr[i]);

        }
        sortArr.Sort();
        return sortArr.Count;
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

            int result = HackerRank.stringSimilarity(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
