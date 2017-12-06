using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPrograms
{
    public class QueueUsingArray
    {
        internal int[] data;
        private int count;
        public const int Capacity = 20;
        private int front;
        public int Front
        {
            get { return front; }
            set { front = value; }
        }

        private int rear;
        public int Rear
        {
            get { return rear; }
            set { rear = value; }
        }

        public QueueUsingArray(int Capacity)
        {
            data = new int[Capacity];
            Front = 0;
            Rear = 0;
        }

        public QueueUsingArray()
            : this(Capacity)
        {

        }

        public bool isEmpty()
        {
            return count == 0;
        }

        public int size()
        {
            return count;
        }

        public void add(int value)
        {
            if (count >= Capacity)
            {
                throw new System.InvalidOperationException("QueueFullException");
            }
            else
            {
                count++;
                data[Rear] = value;
                Rear = (++Rear) % (Capacity - 1);
            }
        }

        public int remove()
        {
            int value;
            if (isEmpty())
            {
                throw new System.InvalidOperationException("Queue is empty exception");
            }
            else
            {
                count--;
                value = data[front];
                front = (++front) % (Capacity - 1);
            }
            return value;
        }

        public void print()
        {
            for (int i = Front; i < Rear; i++)
            {
                Console.WriteLine(data[i].ToString());
            }
        }

    }

    public class QueueUsingLinkedList
    {
        public QueueNode Top = null;
        public QueueNode Bottom = null;
        public int count;
        public class QueueNode
        {
            private int data;

            public int Data
            {
                get { return data; }
                set { data = value; }
            }
            public QueueNode NextNode;
            public QueueNode PreviousNode;

            public QueueNode(int value)
            {
                Data = value;
            }
        }

        public void push(int value)
        {
            QueueNode newNode = new QueueNode(value);

            if (Top == null)
            {
                Top = Bottom = newNode;
            }
            else if (Top == Bottom)
            {
                Top = newNode;
                Bottom.PreviousNode = Top;
                Top.NextNode = Bottom;
                count++;
            }
            else
            {
                Top.PreviousNode = newNode;
                newNode.NextNode = Top;
                Top = newNode;
                count++;
            }
        }

        public QueueNode pop()
        {
            if (Bottom == null)
            {
                throw new System.InvalidOperationException("Queue is empty");
            }

            Bottom.PreviousNode.NextNode = null;
            QueueNode tempNode = Bottom;
            Bottom = tempNode.PreviousNode;
            count--;
            return tempNode;
        }

        public void printQueue()
        {
            if (count == 0)
            {
                throw new System.InvalidOperationException("Queue is emtpy");
            }

            QueueNode printNode = Top;
            Console.WriteLine(printNode.Data);
            while (printNode.NextNode != null)
            {
                printNode = printNode.NextNode;
                Console.WriteLine(printNode.Data);
            }
        }
    }
}
