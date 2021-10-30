using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_DSBINARY1.SORTING_anh.cs.luc.edu
{
   public  class SORT_1
    {
        public static void exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }


        public static void IntArrayBubbleSort(int[] data)
        {
            int i, j;
            int N = data.Length;
            Console.WriteLine(" BUBBLESORT ::  IntArrayBubbleSort(int[] data)");

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (data[i] > data[i + 1])
                        exchange(data, i, i + 1);
                }
            }
        }

        public static void IntArrayBubble(int[] arr)
        {
            Console.WriteLine(" BUBBLESORT ::  IntArrayBubble(int[] arr)");
            for(int i=0; i<arr.Length-1; i++)
            {
                for(int j=0;j<arr.Length-1-i;j++)
                {
                    if(arr[j]>arr[j+1])
                    {
                        exchange(arr, i, j);
                    }

                }

            }

        }
        public static void DisplaySort()
        {
            int[] arr = new int[] { 12, 89, 76, 90, 32, 56, 9, 45, 12, 95 };
            Console.WriteLine(" The Unsorted array " );

            foreach(int i in arr)
            {
                Console.Write(" " + i);
            }
            IntArrayBubbleSort(arr);
            Console.WriteLine(" The SORTED array ");

            foreach (int i in arr)
            {
                Console.Write(" " +i);
            }
            IntArrayBubble(arr);

            Console.WriteLine(" The SORTED array After Bubble Sort ");

            foreach (int i in arr)
            {
                Console.Write(" " + i);
            }
        }

    }

   
}
