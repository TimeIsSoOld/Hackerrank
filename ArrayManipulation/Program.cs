using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulation
{
    class Program
    {
        public object Solve()
        {
            int n = ReadInt();
            int m = ReadInt();
            var data = new Tuple<int, int>[m * 2];
            for (int i = 0; i < m; i++)
            {
                int a = ReadInt();
                int b = ReadInt();
                int k = ReadInt();
                data[2 * i] = Tuple.Create(a, k);
                data[2 * i + 1] = Tuple.Create(b + 1, -k);
            }

            Array.Sort(data);

            long c = 0, max = 0;
            foreach (var t in data)
            {
                c += t.Item2;
                max = Math.Max(max, c);
            }

            return max;
        }

        #region Main

        protected static TextReader reader;
        protected static TextWriter writer;

        static void Main()
        {
#if DEBUG
            reader = new StreamReader("..\\..\\input.txt");
            writer = Console.Out;
            //writer = new StreamWriter("..\\..\\output.txt");
#else
        reader = Console.In;
        writer = new StreamWriter(Console.OpenStandardOutput());
#endif
            try
            {
                object result = new Program().Solve();
                if (result != null)
                    writer.WriteLine(result);
            }
            catch (Exception ex)
            {
#if DEBUG
                Console.WriteLine(ex);
#else
            throw;
#endif
            }
            reader.Close();
            writer.Close();
        }

        #endregion

        #region Read/Write

        private static Queue<string> currentLineTokens = new Queue<string>();

        private static string[] ReadAndSplitLine()
        {
            //string[] aa;
            //aa= reader.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            return reader.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static string ReadToken()
        {
           
            while (currentLineTokens.Count == 0)
            {               
                currentLineTokens = new Queue<string>(ReadAndSplitLine());
            }
            return currentLineTokens.Dequeue();
        }

        public static int ReadInt()
        {
            return int.Parse(ReadToken());
        }

        public static long ReadLong()
        {
            return long.Parse(ReadToken());
        }

        public static double ReadDouble()
        {
            return double.Parse(ReadToken(), CultureInfo.InvariantCulture);
        }

        public static int[] ReadIntArray()
        {
            return ReadAndSplitLine().Select(int.Parse).ToArray();
        }

        public static long[] ReadLongArray()
        {
            return ReadAndSplitLine().Select(long.Parse).ToArray();
        }

        public static double[] ReadDoubleArray()
        {
            return ReadAndSplitLine().Select(s => double.Parse(s, CultureInfo.InvariantCulture)).ToArray();
        }

        public static int[][] ReadIntMatrix(int numberOfRows)
        {
            int[][] matrix = new int[numberOfRows][];
            for (int i = 0; i < numberOfRows; i++)
                matrix[i] = ReadIntArray();
            return matrix;
        }

        public static int[][] ReadAndTransposeIntMatrix(int numberOfRows)
        {
            int[][] matrix = ReadIntMatrix(numberOfRows);
            int[][] ret = new int[matrix[0].Length][];
            for (int i = 0; i < ret.Length; i++)
            {
                ret[i] = new int[numberOfRows];
                for (int j = 0; j < numberOfRows; j++)
                    ret[i][j] = matrix[j][i];
            }
            return ret;
        }

        public static string[] ReadLines(int quantity)
        {
            string[] lines = new string[quantity];
            for (int i = 0; i < quantity; i++)
                lines[i] = reader.ReadLine().Trim();
            return lines;
        }

        public static void WriteArray<T>(IEnumerable<T> array)
        {
            writer.WriteLine(string.Join(" ", array));
        }

        #endregion
    }
}
