using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithumsAndDataStructures
{
    public class LinkedList<GenericValue> // creates the class which holds the list
    {
        public class node<GenricValue>
        {
            public GenricValue data;
            public node<GenricValue> nextnode;
        }

        node<GenericValue> head;

        public GenericValue GetDataAtIndex(int index)
        {
            int depth = 0;
            node<GenericValue> currentnode = head;
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

        public GenericValue GetDataAtHead()
        {
            return head.data;
        }

        public GenericValue GetDataAtTail()
        {
            node<GenericValue> currentnode = head;
            while (currentnode.nextnode != null)
            {
                currentnode = currentnode.nextnode;
            }
            //at this point, current node IS the last node
            return currentnode.data;
        }

        public void AddToEndOfList(GenericValue ItemToAdd) //creates function to insert new node (but only at the end of the list)
        {
            node<GenericValue> temp = new node<GenericValue>();
            temp.data = ItemToAdd;

            if (head == null)
            {
                head = temp;
                return;
            }
            else
            {
                node<GenericValue> currentnode = head;
                while (currentnode.nextnode != null)
                {
                    currentnode = currentnode.nextnode;
                }
                currentnode.nextnode = temp;
            }
        }

        public void DeleteAtIndex(int index) //creates function to delete a node by comparing the string to an Item to 
        {
            int depth = 0;
            node<GenericValue> currentnode = head;
            node<GenericValue> parentNode = null;

            while (currentnode.nextnode != null && depth < index)
            {
                parentNode = currentnode;
                currentnode = currentnode.nextnode;
                depth++;
            }

            if (depth == index)
            {
                parentNode.nextnode = currentnode.nextnode;
            }
            else { Console.WriteLine("Index not found"); 
            }
        }

        public void MoveNodeUpOnePlace(int index)
        {
            int depth = 0;
            node<GenericValue> currentnode = head;
            node<GenericValue> parentNode = null;         

            while (currentnode.nextnode != null && depth < index)
            {
                parentNode = currentnode;
                currentnode = currentnode.nextnode;
                depth++;
            }

            if (depth == index)
            {
                GenericValue temp =  parentNode.data;
                parentNode.data = currentnode.data;
                currentnode.data = temp;
               
                            }
            else { Console.WriteLine("Is the error here?"); }
        }

        public void MoveNodeDownOnePlace(int Index)
        {

            int depth = 0;
            node<GenericValue> currentnode = head;
            node<GenericValue> parentNode = null;

            while (currentnode.nextnode != null && depth < Index)
            {
                parentNode = currentnode;
                currentnode = currentnode.nextnode;
                depth++;
            }

            if (depth == Index)
            {
                GenericValue temp = currentnode.data;
                currentnode.data = currentnode.nextnode.data;
                currentnode.nextnode.data = temp;          
            }
            else { Console.WriteLine("Is the error here?"); 
            }
        }

        public void InsertAtIndex(GenericValue ItemToAdd, int Index) //creates function to insert new node (but only at the end of the list)
        {
            int depth = 0;
            node<GenericValue> currentnode = head;
            node<GenericValue> parentNode = null;
            node<GenericValue> newNode = new node<GenericValue>();
            newNode.data = ItemToAdd;
            while (currentnode.nextnode != null && depth != Index)
            {
                parentNode = currentnode;
                currentnode = currentnode.nextnode;
                depth++;
            }

            if (Index == 0)
            {
                newNode = head;
                newNode.nextnode = currentnode;
                head = currentnode;
            }

            
            else if (currentnode.nextnode == null && Index!> depth)
            {
                //currentnode.nextnode = newNode;
                Console.WriteLine("Error, index not found");
                return;
            }

            else if (depth == Index)
            {
                parentNode.nextnode = newNode;
                newNode.nextnode = currentnode;
            }
            else { Console.WriteLine("Index not found"); 
            }
        }

        public void DeleteLastNode()
        {
            node<GenericValue> currentnode = head;
            node<GenericValue> parentNode = null;
            while (currentnode.nextnode != null)
            {
                parentNode = currentnode;
                currentnode = currentnode.nextnode;
            }
            parentNode.nextnode = null;

            //at this point, current node IS the last node
            //return currentnode.data;
        }
    }
}