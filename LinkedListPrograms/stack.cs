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

    
}
