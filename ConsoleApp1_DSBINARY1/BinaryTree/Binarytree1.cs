using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_DSBINARY1.BinaryTree
{
    public class Binarytree1
    {
        public class nodeBT
        {
            public int data = 0;
            public nodeBT leftChild = null;
            public nodeBT rightChild = null;
        };

        public static nodeBT CreateNode(int data)
        {
            nodeBT node = new nodeBT();   // "new" is like "malloc"
            node.data = data;
            node.leftChild = null;
            node.rightChild = null;
            return (node);
        }
        // Inorder traversal
        public static void inorderTraversal(nodeBT root)
        {
            if (root == null) return;
            inorderTraversal(root.leftChild);
            Console.WriteLine(root.data);
            inorderTraversal(root.rightChild);
        }

        public static void PreorderTraversal(nodeBT root)
        {
            if (root == null) return;
            Console.WriteLine(root.data);
            PreorderTraversal(root.leftChild);          
            PreorderTraversal(root.rightChild);
        }

        public static void PostorderTraversal(nodeBT root)
        {
            if (root == null) return;      
            PostorderTraversal(root.leftChild);
            PostorderTraversal(root.rightChild);
            Console.WriteLine(root.data);
        }

        // Insert on the left of the node
        public  static nodeBT  insertLeft(nodeBT root, int value)
        {
          root.leftChild = CreateNode(value);
          return root.leftChild;
         }

        // Insert on the right of the node
        public static nodeBT insertRight(nodeBT root, int value)
        {
            root.rightChild = CreateNode(value);
            return root.rightChild;
        }
        public static  void Display()
        {
            Console.WriteLine();
            Console.WriteLine(" Inside BINARY TREE ");
            Console.WriteLine(" {0, -10 } " , "Inside BINARY TREE ");
            nodeBT root = CreateNode(1);
            insertLeft(root, 2);
            insertRight(root, 3);
            insertLeft(root.leftChild, 4);

            Console.WriteLine("Inorder traversal \n");
            inorderTraversal(root);
            Console.WriteLine("\nPreorder traversal \n");
            PreorderTraversal(root);
            Console.WriteLine("\nPostorder traversal \n");            
            PostorderTraversal(root);

        }
    }
}
