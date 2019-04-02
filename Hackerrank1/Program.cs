using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  int[] a = { 1, 2, 3, 4, 5 };
            //int n = 5;
            //int d = 4;
            //  = reverseArray1(a,n,d);
            //int[] aa = matchingStrings(strings,queries);
            long aa = arrayManipulation(n,queries);
        }
        static int[] reverseArray(int[] a)
        {
            int[] b = new int[a.Length];
            int count = a.Length - 1;
            for (int i = 0; i < a.Length; i++)
            {
                b[count] = a[i];
                count--;
            }
            return b;
        }
        static int[] reverseArray1(int[] a, int n, int d)
        {
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                if (i - d < 0)
                {
                    int Phasereduction = n + (i - d);
                    b[Phasereduction] = a[i];
                }
                else if (i - d >= 0)
                {
                    b[i - d] = a[i];
                }

            }
            return b;
        }
        //static string[] strings = { "ab", "ab", "abc"};
        // static string[] queries = {"ab","abc","bc" };
        static int[] matchingStrings(string[] strings, string[] queries)
        {
            int[] Coutarr = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                int aaa = 0;
                for (int j = 0; j < strings.Length; j++)
                {
                    if (queries[i] == strings[j])
                    {
                        aaa++;
                        Coutarr[i] = aaa;
                    }
                }
            }
            return Coutarr;
        }
       static   int n = 10;
      static  int[][] queries = new int[3][] { new int[] { 1, 5 ,3 }, new int[] { 4, 10 ,7 }, new int[] { 6, 9 ,1 } };
        //static int[][] queries = new int[3][] { new int[] { 1, 2, 100 }, new int[] { 2, 5, 100 }, new int[] { 3, 4, 100 } };

        static long arrayManipulation(int n, int[][] queries)
        {
            long[] aaa = new long[n];         
            for (long i = 0; i < queries.Length; i++)
            {
                    long friIndex = queries[i][0];
                    long secIndex = queries[i][1];
                    long addcount = queries[i][2];
                for (long j = 0; j <secIndex-friIndex+1 ; j++)
                {
                    aaa[friIndex-1+j] += addcount;
                }             
            }
            long max = aaa[0];
            for (long i = 0; i < aaa.Length; i++)
            {
                if (aaa[i]>max)
                {
                    max = aaa[i];
                }
            }
            return max;
        }
    }
}