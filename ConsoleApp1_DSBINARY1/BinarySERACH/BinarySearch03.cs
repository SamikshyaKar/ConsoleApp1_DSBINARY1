using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_DSBINARY1.BinarySERACH
{
    public class BinarySearch03
    {
        public static void exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }
        public static void IntArrayShellSort(int[] data, int[] intervals)
        {
            int i, j, k, m;
            int N = data.Length;

            // The intervals for the shell sort must be sorted, ascending

            for (k = intervals.Length - 1; k >= 0; k--)
            {
                int interval = intervals[k];
                for (m = 0; m < interval; m++)
                {
                    for (j = m + interval; j < N; j += interval)
                    {
                        for (i = j; i >= interval && data[i] < data[i - interval]; i -= interval)
                        {
                            exchange(data, i, i - interval);
                        }
                    }
                }
            }
        }

        public static void IntArrayShellSortBetter(int[] data)
        {
            int[] intervals = GenerateIntervals(data.Length);
            IntArrayShellSort(data, intervals);
        }

        static int[] GenerateIntervals(int n)
        {
            if (n < 2)
            {  // no sorting will be needed
                return new int[0];
            }
            int t = Math.Max(1, (int)Math.Log(n, 3) - 1);
            int[] intervals = new int[t];
            intervals[0] = 1;
            for (int i = 1; i < t; i++)
                intervals[i] = 3 * intervals[i - 1] + 1;
            return intervals;
        }

        public static int IntArrayBinarySearch(int[] data, int item)
        {

            int min = 0;
            int N = data.Length;
            int max = N - 1;
            do
            {
                int mid = (min + max) / 2;
                if (item > data[mid])
                    min = mid + 1;
                else
                    max = mid - 1;
                if (data[mid] == item)
                    return mid;
                //if (min > max)
                //   break;
            } while (min <= max);
            return -1;
        }

        public static void DisplayBinary()
        {
            Console.WriteLine("Please enter some integers, separated by spaces:");
            string input = Console.ReadLine();
            string[] integers = input.Split(' ');
            int[] data = new int[integers.Length];
            for (int i = 0; i < data.Length; i++)
                data[i] = int.Parse(integers[i]);

            IntArrayShellSortBetter(data);
            while (true)
            {
                Console.WriteLine("Please enter a number you want to find (blank line to end):");
                input = Console.ReadLine();
                if (input.Length == 0)
                    break;
                int searchItem = int.Parse(input);
                int foundPos = IntArrayBinarySearch(data, searchItem);
                if (foundPos < 0)
                    Console.WriteLine("Item {0} not found", searchItem);
                else
                    Console.WriteLine("Item {0} found at position {1}", searchItem, foundPos);
            }




        }
    }
}
