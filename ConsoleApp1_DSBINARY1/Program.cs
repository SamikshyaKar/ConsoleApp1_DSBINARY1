using System;
using ConsoleApp1_DSBINARY1.BinarySERACH;
using ConsoleApp1_DSBINARY1.BinaryTree;
using ConsoleApp1_DSBINARY1.SORTING_anh.cs.luc.edu;

namespace ConsoleApp1_DSBINARY1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            static string Indent(int count)
            {
                return " ".PadLeft(count);
            }
            Console.WriteLine(Indent(18) + " BINARY SEARCH " );
            BinarySearch01.DisplayBinary();
            BinarySearch02.DisplayBinraysearch();
            BinarySearch03.DisplayBinary();
            SORT_1.DisplaySort();
            Console.WriteLine(Indent(18)+ "    BINARY TREE " );
            Binarytree1.Display();
            MyBINARYTREE.display();
            ExperimentalBinaryTree_Mycodescoolc___derivation.NodeMyCodeSchool.display();
            
        }
    }
}
