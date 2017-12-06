using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPrograms
{
    public class Tree
    {

        public TreeNode root;
        public Tree()
        {
            root = null; 
        }
        public void inOrderTraversal(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            inOrderTraversal(node.lchild);
            Console.WriteLine(node.data);
            inOrderTraversal(node.rchild);
        }

        public void preOrderTraversal(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            Console.WriteLine(node.data);
            preOrderTraversal(node.lchild);
            preOrderTraversal(node.rchild);
        }

        public void postOrderTraversal(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            postOrderTraversal(node.lchild);
            postOrderTraversal(node.rchild);
            Console.WriteLine(node.data);
        }
    }

    public class TreeNode
    {
        public int data;
        public TreeNode lchild, rchild;
        public TreeNode(TreeNode lChild, TreeNode rChild, int item)
        {
            lchild = lChild;
            rchild = rChild;
            data = item;
        }

        public TreeNode(int item)
        {
            lchild = null;
            rchild = null;
            data = item;
        }


    }
}
