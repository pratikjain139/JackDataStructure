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

        //breadth first traversal
        public void printGivenLevel(TreeNode root,int level)
        {
            if (root == null)
            {
                return;
            }

            if(level == 1)
            {
                Console.WriteLine(root.data);
            }

            if (level > 1)
            {
                printGivenLevel(root.lchild, level - 1);
                printGivenLevel(root.rchild, level - 1);
            }
        }

        //breadth first traversal using queue
        public void breadthFirstTraversal(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            QueueUsingLinkedListGeneric<TreeNode> queue = new QueueUsingLinkedListGeneric<TreeNode>();
            queue.push(root);
            TreeNode temp;
            while(queue.count != 0)
            {
                temp = queue.pop();
                Console.WriteLine(temp.data);
                if(temp.lchild != null)
                {
                    queue.push(temp.lchild);
                }

                if (temp.rchild != null)
                {
                    queue.push(temp.rchild);
                }
            }

        }

        public int height(TreeNode root)
        {
            if (root == null)
                return 0;
            else
            {
                /* compute  height of each subtree */
                int lheight = height(root.lchild);
                int rheight = height(root.rchild);

                /* use the larger one */
                if (lheight > rheight)
                    return (lheight + 1);
                else return (rheight + 1);
            }
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
