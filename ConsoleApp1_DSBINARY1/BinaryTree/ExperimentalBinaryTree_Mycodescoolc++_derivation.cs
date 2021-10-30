using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_DSBINARY1.BinaryTree
{
   public class ExperimentalBinaryTree_Mycodescoolc___derivation
    {
       public  class NodeMyCodeSchool
        {
            int data = 0;
            NodeMyCodeSchool leftchild = null;
            NodeMyCodeSchool rightchild = null;

          

            public static NodeMyCodeSchool insert(NodeMyCodeSchool root, int data)
            {
                if(root==null)
                {
                    root = GetNewNode(data);
                    return root;
                }

                else if (data<=root.data)
                {
                    root.leftchild = insert(root, data);
                    return root;
                }
                else
                {
                    root.rightchild = insert(root, data);
                    return root;
                }
               
            }
            public static NodeMyCodeSchool GetNewNode(int data)
            {
                NodeMyCodeSchool nodeal = new NodeMyCodeSchool();
                nodeal.data = data;
                nodeal.leftchild = null;
                nodeal.rightchild = null;
                return nodeal;
            }
            public static void display()
            {
                Console.WriteLine();
                Console.WriteLine(" EXPERIMENTS from MYCODESCHOOL C ++");
                NodeMyCodeSchool root = null;
                root= insert(root, 15);
                root= insert(root, 25);
                root= insert(root, 35);
                root= insert(root, 20);
                Console.ReadLine();

            }
          

        }

    }
}
