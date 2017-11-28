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
            Node firstNode= new Node(1);
            LinkedList linkLst = new LinkedList(firstNode);
            Node secondNode = new Node(2);
            Node thirdNode = new Node(3);
            firstNode.next = secondNode;

            secondNode.next = thirdNode;
            secondNode.previous = firstNode;
            thirdNode.previous = secondNode;
            linkLst.printAllNodes();
        }
    }
}
