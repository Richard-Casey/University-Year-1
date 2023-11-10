using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithumsAndDataStructures
{
    public class DoubleList<T> // creates the class which holds the list
    {
        public class node<T>
        {
            public T data;
            public node<T> nextnode;
            public node<T> previousnode;
        }

        node<T> head;

        public T GetDataAtIndex(int index)
        {
            int depth = 0;
            node<T> currentnode = head;
            
            while (currentnode.nextnode != null && depth < index)
            {
                currentnode = currentnode.nextnode;
                depth++;
            }


            if (depth == index)
            {
                return currentnode.data;
            }
            else
            {
                Console.WriteLine("Error Depth > Index");
                return default;
            }
        }
        public T GetDataAtHead()
        {
            return head.data;
        }
    
    public T GetDataAtTail()
    {
        node<T> currentnode = head;
        while (currentnode.nextnode != null)
        {
            currentnode = currentnode.nextnode;
        }
               return currentnode.data;
    }

    public void AddToEndOfList(T ItemToAdd) //creates function to insert new node (but only at the end of the list)
        {
            {
                node<T> currentnode = head;
                node<T> parentnode = null;
                node<T> temp = new node<T>();
                temp.data = ItemToAdd;

                if (head == null)
                {
                    head = temp;
                    return;
                }
                else
                {                    
                    while (currentnode.nextnode != null)
                    {
                        parentnode = currentnode;
                        currentnode = currentnode.nextnode;
                    }

                    currentnode.nextnode = temp;
                    currentnode.nextnode.previousnode = currentnode;
                }

            }
        }

        public void InsertAtIndex(T ItemToAdd, int Index) //creates function to insert new node at specified index
        {
            {
                int depth = 0;
                node<T> currentnode = head;
                node<T> parentNode = null;
                node<T> newNode = new node<T>();
                newNode.data = ItemToAdd;
                while (currentnode.nextnode != null && depth != Index)
                {
                    parentNode = currentnode;
                    currentnode = currentnode.nextnode;
                    depth++;
                }

                if (Index == 0)
                {
                    newNode.nextnode = head;
                    head.previousnode = newNode;
                    head = newNode;
                }

                else if (currentnode.nextnode == null && Index !> depth)
                {
                    
                    Console.WriteLine("Error, index not found");
                    return;
                }

                else if (depth == Index)
                {
                    parentNode.nextnode = newNode;
                    newNode.previousnode = parentNode;

                    newNode.nextnode = currentnode;
                    currentnode.previousnode= newNode;
                }

                else { Console.WriteLine("Index not found"); 
                }
            }


        }

        public void DeleteAtIndex(int index) //creates function to delete a node by comparing the string to an Item to 
        {
            int depth = 0;
            node<T> currentnode = head;
            node<T> parentNode = null;

            while (currentnode.nextnode != null && depth < index)
            {
                parentNode = currentnode;
                currentnode = currentnode.nextnode;
                depth++;
            }

            if (depth == index)
            {
                parentNode.nextnode = currentnode.nextnode;
                currentnode.nextnode.previousnode = parentNode;
            }
            else { Console.WriteLine("Index not found"); 
            }
        }

        public void DeleteLastNode() 
        {
            node<T> currentnode = head;
            node<T> parentNode = null;
            while (currentnode.nextnode != null)
            {
                parentNode = currentnode;
                currentnode = currentnode.nextnode;
            }
            parentNode.nextnode = null;          
        }

        public void MoveNodeUpOnePlace(int Index)
        {
            int depth = 0;
            node<T> currentnode = head;
            node<T> parentNode = null;

            while (currentnode.nextnode != null && depth < Index)
            {
                parentNode = currentnode;
                currentnode = currentnode.nextnode;
                depth++;
            }

            if (depth == Index)
            {
                T temp = parentNode.data;
                parentNode.data = currentnode.data;
                currentnode.data = temp;

            }
            else { Console.WriteLine("Is the error here?"); 
            }
        }

        public void MoveNodeDownOnePlace(int Index)
        {
            int depth = 0;
            node<T> currentnode = head;
            node<T> parentNode = null;

            while (currentnode.nextnode != null && depth < Index)
            {
                parentNode = currentnode;
                currentnode = currentnode.nextnode;
                depth++;
            }

            if (depth == Index)
            {
                T temp = currentnode.data;
                currentnode.data = currentnode.nextnode.data;
                currentnode.nextnode.data = temp;


            }
            else { Console.WriteLine("Is the error here?"); }
        }

    }

}
