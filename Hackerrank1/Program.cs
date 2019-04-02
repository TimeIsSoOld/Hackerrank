using System;
using System.Collections.Generic;
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
            int[] aa = matchingStrings(strings,queries);
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
        static int[] reverseArray1(int[] a,int n,int d)
        {
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                if (i-d<0)
                {
                    int Phasereduction = n+(i - d);
                    b[Phasereduction]=a[i];
                }
                else if(i-d>=0)
                {
                   b[i - d] = a[i] ;
                }

            }
            return b;
        }
        static string[] strings = { "ab", "ab", "abc"};
        static string[] queries = {"ab","abc","bc" };
        static int[] matchingStrings(string[] strings, string[] queries)
        {
            int[] Coutarr = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                int aaa = 0;
                for (int j = 0; j < strings.Length; j++)
                {
                    if (queries[i]==strings[j])
                    {
                        aaa++;
                        Coutarr[i] = aaa;
                    }
                }
            }
            return Coutarr;
        }
    }
}