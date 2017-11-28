﻿using System;
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
            Node firstNode= new Node(1);
            LinkedList linkLst = new LinkedList(firstNode);
            Node secondNode = new Node(2);
            Node thirdNode = new Node(3);
            firstNode.next = secondNode;

            secondNode.next = thirdNode;
            secondNode.previous = firstNode;
            thirdNode.previous = secondNode;
            Node fourthNode = new Node(4);
            Node fifthNode = new Node(5);
            Node sixthNode = new Node(6);
            linkLst.addNode(EnumPosition.index, fourthNode, 2);
            linkLst.addNode(EnumPosition.start, fifthNode, null);
            linkLst.addNode(EnumPosition.end, sixthNode, null);
            linkLst.printAllNodes();
        }
    }
}
