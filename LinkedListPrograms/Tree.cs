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

        //breadth first traversal using linkedlist
        public void printGivenLevel(TreeNode root,int level)
        {
            if (root == null)
            {
                return;
            }

            if(level == 1)
            {
                Console.WriteLine(root.value);
            }

            if (level > 1)
            {
                printGivenLevel(root.lchild, level - 1);
                printGivenLevel(root.rchild, level - 1);
            }
        }

        //------Depth first tree traversal without recursion

        public void depthFirstTreeTraversal(TreeNode root)
        {
            stack<TreeNode> stk = new stack<TreeNode>();
            stk.push(root);
            while (!stk.isEmpty())            
            {
                TreeNode tempNode = stk.pop();
                Console.WriteLine(tempNode.value);
                if (tempNode.lchild != null)
                {
                    stk.push(tempNode.lchild);
                }

                if (tempNode.rchild != null)
                {
                    stk.push(tempNode.rchild);
                }
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
                Console.WriteLine(temp.value);
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

        public void initPrintAllPaths(TreeNode root)
        {
            stack<TreeNode> treeStack = new stack<TreeNode>();
            printAllPaths(root, treeStack);
        }
        public void printAllPaths(TreeNode node, stack<TreeNode> treeStack) 
        {
            if (node == null)
            {
                return;
            }

            treeStack.push(node);

            if(node.lchild == null && node.rchild == null)
            {
                treeStack.printStack();
                treeStack.pop();
                return;
            }

            if (node.lchild != null) 
            {
                printAllPaths(node.lchild, treeStack);
            }

            if (node.rchild != null)
            {
                printAllPaths(node.rchild, treeStack);
            }

            treeStack.pop();

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

        //----------Below all are ways of depth first tree traversal-----------
        public void inOrderTraversal(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            inOrderTraversal(node.lchild);
            Console.WriteLine(node.value);
            inOrderTraversal(node.rchild);
        }

        public void preOrderTraversal(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            Console.WriteLine(node.value);
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
            Console.WriteLine(node.value);
        }
    }

    public class TreeNode
    {
        public int value;
        public TreeNode lchild, rchild;
        public TreeNode(TreeNode lChild, TreeNode rChild, int item)
        {
            lchild = lChild;
            rchild = rChild;
            value = item;
        }

        public TreeNode(int item)
        {
            lchild = null;
            rchild = null;
            value = item;
        }
    }


}
