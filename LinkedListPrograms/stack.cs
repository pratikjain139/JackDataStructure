using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPrograms
{
    public class stack<T>
    {        
        public stackNode Top;
        public class stackNode 
        {
            public T data;
            public stackNode next;
            public stackNode(T data)
            {
                this.data = data;
            }        
        }

        public T pop()
        {   
            if (isEmpty())
            {
                Console.WriteLine("stack is empty");         
            }
            else
            {         
                Top = Top.next;
            }
            return Top.data;

        }

        public void push(T data)
        {
            stackNode newNode = new stackNode(data);
            if (isEmpty())
            {
                Top = newNode;
            }
            else
            {
                newNode.next = Top;
                Top = newNode;
            }
        }

        public bool isEmpty()
        {
            return Top == null;
        }

        public T peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("stack is empty");
                throw new Exception("stack is empty");
            }
            return Top.data;
        }

        public void printStack()
        {
            if (isEmpty())
            {
                Console.WriteLine("stack is empty. no data ot print");
            }
            stackNode nextNode = Top;
            Console.WriteLine(nextNode.data.ToString());
                        
            while (nextNode.next != null)
            {
                nextNode = nextNode.next;
                Console.WriteLine(nextNode.data.ToString());
            }
            
        }

    }
    
    public class stackArray
    {
        public const int stacksize= 10;
        # region properties
        
        private int top;
        public int Top
        {
            get { return top; }
            set { top = value; }
        }
        
        #endregion     
        public int[] data;

        public stackArray()
            : this(stacksize)
        { 
        }
        public stackArray(int stacksize)
        {
            Top = -1;
            data = new int[stacksize];
        }

        public void push(int item)
        {
            if (Top == 10)
            {
                Console.WriteLine("Array is full");
                return;
            }

            data[++Top] = item;
        }

        public int pop()
        {
            if (Top == -1) 
            {
                Console.WriteLine("Array is empty");
                throw new Exception("array is empty");
            }

            return data[Top--];
        }

        public void printStack() 
        {
            for (int i = 0; i <= Top ; i++) 
            {
                Console.WriteLine(data[i].ToString());
            }
        }

    }

    public class stackDynamicArray
    {
        private const int capacity = 5;
        
        private int[] data;
        private int Top = -1;

        #region properties
        private int mincapacity;
        public int MinCapacity
        {
            get { return mincapacity; }
            set { mincapacity = value; }
        }

        private int maxcapacity;

        public int MaxCapacity
        {
            get { return maxcapacity; }
            set { maxcapacity = value; }
        }

        #endregion

        # region constructors
        public stackDynamicArray(int capacity)
        {
            MinCapacity = MaxCapacity = capacity;
            data = new int[MinCapacity];
        }

        public stackDynamicArray()
            : this(capacity)
        {

        }
        #endregion

        #region methods
        public int size()
        {
           return Top + 1;
        }

        public void push(int item)
        {
            if(size() == MaxCapacity)
            {
                int[] newData = new int[MaxCapacity*2];
                Array.Copy(data,0,newData,0,MaxCapacity);
                data = newData;
                MaxCapacity = MaxCapacity * 2;
                Console.WriteLine("size doubled");
            }
            data[++Top] = item;            
        }

        public int pop()
        {
            if (Top == -1) 
            {
                throw new Exception("Array is empty");
            }
            if (size() == MaxCapacity / 2 && MaxCapacity > MinCapacity)
            {
                MaxCapacity = MaxCapacity / 2;
                int[] newData = new int[MaxCapacity];
                Array.Copy(data, newData, MaxCapacity);
                data = newData;
                Console.WriteLine("size halfed");
            }
            return data[Top--];
        }

        public void print()
        {
            for (int i = 0; i <= Top; i++)
            {
                Console.WriteLine(data[i].ToString());
            }
        }
        #endregion

    }
    
}
