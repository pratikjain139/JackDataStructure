using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPrograms
{
    public class LinkedList
    {
        public Node head;
        public LinkedList(Node h)
        {
            head = h;
        }

        public void printAllNodes() 
        {
            Node currentNode= head;
            do
            {
                Console.WriteLine(currentNode.data.ToString());
                currentNode = currentNode.next;
            }
            while (currentNode != null);
            Console.ReadLine();
        }



        public void addNode(EnumPosition pos, Node newNode, int? position = null)
        {
            Node currentNode;
            switch (pos) 
            {
                case EnumPosition.start:
                    head.previous = newNode;
                    newNode.next = head;
                    this.head = newNode;
                    break;
                case EnumPosition.end:
                    currentNode = this.head;
                    while (currentNode.next != null) 
                    {
                        currentNode = currentNode.next;
                    }
                    currentNode.next = newNode;
                    break;
                case EnumPosition.index:
                    currentNode = this.head;
                    int i = 1;
                    while (currentNode.next != null) 
                    {                        
                        if (i == position.GetValueOrDefault()) 
                        {
                            newNode.next = currentNode;
                            newNode.previous = currentNode.previous;
                            currentNode.previous.next = newNode;
                            currentNode.previous = newNode;
                            break;
                        }
                        currentNode = currentNode.next;
                        i++;
                    }
                    
                    break;
            }
        }
    }
    public enum EnumPosition
    {
        start = 1,
        end = 2,
        index = 3
    }
    public class Node
    {
        public int data;
        public Node next;
        public Node previous;
        public Node(int d)
        {
            data = d;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //-----Linked list code----
            //Node firstNode= new Node(1);
            //LinkedList linkLst = new LinkedList(firstNode);
            //Node secondNode = new Node(2);
            //Node thirdNode = new Node(3);
            //firstNode.next = secondNode;

            //secondNode.next = thirdNode;
            //secondNode.previous = firstNode;
            //thirdNode.previous = secondNode;
            //Node fourthNode = new Node(4);
            //Node fifthNode = new Node(5);
            //Node sixthNode = new Node(6);
            //linkLst.addNode(EnumPosition.index, fourthNode, 2);
            //linkLst.addNode(EnumPosition.start, fifthNode, null);
            //linkLst.addNode(EnumPosition.end, sixthNode, null);
            //linkLst.printAllNodes();


            //-----stack code --------
            //stack<int> myStack = new stack<int>();
            //myStack.push(1);
            //myStack.push(2);
            //myStack.push(3);
            //myStack.push(4);
            //myStack.push(5);
            //myStack.push(6);
            //myStack.printStack();
            //Console.WriteLine("Top is: " + myStack.peek());
            //myStack.pop();
            //myStack.printStack();
            //Console.ReadLine();

            //---------stack array-------------

            //stackArray myStack = new stackArray();
            //myStack.push(1);
            //myStack.push(2);
            //myStack.push(3);
            //myStack.push(4);
            //myStack.push(5);
            //myStack.push(6);
            //myStack.printStack();
            //Console.WriteLine("Item popped is " + myStack.pop().ToString());
            //myStack.printStack();
            //Console.ReadLine();

            //---- stack using dynamic array
            //stackDynamicArray myStack = new stackDynamicArray();
            //for (int i = 1; i <= 20; i++)
            //{
            //    myStack.push(i);
            //}
            //myStack.print();
            //int length = myStack.size();
            //for (int j = 1; j <= length; j++)
            //{
            //    myStack.pop();
            //}
            //myStack.print();
            //Console.ReadLine();

            //---- queue using array----------
            //QueueUsingArray myQueue = new QueueUsingArray();
            //for (int i = 0; i < 10; i++) 
            //{
            //    myQueue.add(i);
            //}

            //myQueue.print();
            //Console.ReadLine();

            //for (int i = 0; i < 5; i++)
            //{
            //    myQueue.remove();
            //}

            //myQueue.print();
            //Console.ReadLine();

            //-----------Queue using linked list-----------
            //QueueUsingLinkedList myQueue = new QueueUsingLinkedList();
            //for (int i = 1; i < 10; i++)
            //{
            //    myQueue.push(i);
            //}
            //myQueue.printQueue();
            //Console.ReadLine();

            //for (int i = 1; i < 6; i++)
            //{
            //    myQueue.pop();
            //}
            //myQueue.printQueue();
            //Console.ReadLine();

            //-----------------Binary Tree----------------
            Tree myTree = new Tree();
            TreeNode rootNode = new TreeNode(1);
            TreeNode secondNode = new TreeNode(2);
            TreeNode thirdNode = new TreeNode(3);
            TreeNode fourthNode = new TreeNode(4);
            TreeNode fifthNode = new TreeNode(5);

            rootNode.lchild = secondNode;
            rootNode.rchild = thirdNode;
            secondNode.lchild = fourthNode;
            secondNode.rchild = fifthNode;
            myTree.root = rootNode;

            //Console.WriteLine("In order traversal");
            //myTree.inOrderTraversal(myTree.root);

            //Console.WriteLine("pre order traversal");
            //myTree.preOrderTraversal(myTree.root);

            //Console.WriteLine("Post order traversal");
            //myTree.postOrderTraversal(myTree.root);


            //---------------- Breadth first traversal using recursion-----------------------------
            
            //Console.WriteLine("Height: " + myTree.height(rootNode).ToString());
            //int height = myTree.height(rootNode);
            //for (int i = 1; i <= height; i++)
            //{
            //    myTree.printGivenLevel(rootNode, i);
            //}

            //--------------------Breadth first traversal using queue------------------
            myTree.breadthFirstTraversal(myTree.root);

                Console.ReadLine();



        }
    }
}
