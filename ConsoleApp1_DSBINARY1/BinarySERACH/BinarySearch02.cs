using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_DSBINARY1.BinarySERACH
{
    public class BinarySearch02
    {
         static int binaryScr(int[] a, int low, int high, int m)
        {
            if (high >= low)
            {
                int mid = low + (high - low) / 2;
                if (a[mid] == m)
                    return mid;
                if (a[mid] > m)
                    return binaryScr(a, low, mid - 1, m);
                return binaryScr(a, mid + 1, high, m);
            }
            return -1;
        }

       public static int DisplayBinraysearch()
        {
            int[] a = { 12, 13, 21, 36, 40 };
            int i, m;
            Console.WriteLine();
            for (i = 0; i < 5; i++)
            {
                Console.Write(" " + a[i]); 
            }
            Console.WriteLine();
            Console.WriteLine("\n ");
            int n = a.Length;
            Console.WriteLine("Enter the number to be searched");
             m = int.Parse(Console.ReadLine());
            int result = binaryScr(a, 0, n - 1, m);
            Console.WriteLine((result == -1) ? "The element is not present in array": ("The element is present at index " + result));
            Console.WriteLine();            
            return 0;
        }
    }
}
