using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithumsAndDataStructures
{
    public class Stack<T>
    {
       public class node <T>
        {
            public T data;
            public node<T> nextnode;
        }

        node<T> Root;

        public T Pop()
        {
            node<T> currentnode = Root;
            node<T> parentnode = null;

            if (currentnode.nextnode == null)
            {
                return currentnode.data;
            }

            while (currentnode.nextnode != null)
            {
                parentnode = currentnode;
                currentnode = currentnode.nextnode;
            }
            parentnode.nextnode = null;
            parentnode = currentnode;
            return currentnode.data;
        }

        public void Push(T data)
        {

            node <T> newNode = new node<T>();
            newNode.data = data;

            if (Root == null)
            {
                Root = newNode;
                return;
            }
            else
            {
                node<T> currentnode = Root;
                while (currentnode.nextnode != null)
                {
                    currentnode = currentnode.nextnode;
                }
                currentnode.nextnode = newNode;

            }


        }

        public T Peek()
        {
            node<T> currentnode = Root;
            while (currentnode.nextnode != null)
            {
                currentnode = currentnode.nextnode;
            }
           
            return currentnode.data;
        }
        
    }
}
