using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_DSBINARY1.BinarySERACH
{
   public  class BinarySearch01
    {
        public static int BinarySearchDisplay(int[] arr, int key)
        {
            int minNum = 0;
            int maxNum = arr.Length - 1;

            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (key == arr[mid])
                {
                    return ++mid;
                }
                else if (key < arr[mid])
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }
            return -1;

            
        }

        public static void DisplayBinary()
        {
            //int[] arr = new int[] { 23, 67, 87, 4, 90, 17, 22, 88, 33, 25 };
            int[] arr = new int[] { 4,17,22,23,25,33,67,87,88,90 };
            int  key = 17;
            Console.WriteLine(" Binary Search Result is ");
           int position = BinarySearchDisplay(arr, key);
            if (position == -1)
            {
                Console.WriteLine(" Item " + key + " Not found");
            }
            else
            {
                Console.WriteLine(" Item found at " + position + " Place ");
            }

            // find out for all positions 
            Console.WriteLine();
            Console.WriteLine(" {0,-10 } " , " find out for all positions ");
            for (int i=0; i < arr.Length; i++)
            {
               int key1 = arr[i];
                int positionall = BinarySearchDisplay(arr, key1);
                if (positionall == -1)
                {
                    Console.WriteLine(" Item " + key1 + " Not found");
                }
                else
                {
                    Console.WriteLine(" Item found at " + positionall + " Place ");
                }

            }
        }
    }
}
