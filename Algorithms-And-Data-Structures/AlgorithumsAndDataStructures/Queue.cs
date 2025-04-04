using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithumsAndDataStructures
{
    public class Queue<T>
    {
        private T[] ele;
        private int front;
        private int rear;
        private int max;

        public Queue(int size)
        {
            ele = new T[size];
            front = 0;
            rear = -1;
            max = size;
        }

        public void Enqueue(T ItemToAdd) // This is someone/something being added to the back of or is joining the queue
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                ele[++rear] = ItemToAdd;
            }
        }


        public T Peek() //  This is looking at the data held at the front of the queue
        {
            return ele[front];

        }


        public T Dequeue() //deletes front of queue
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return default;
            }
            else
            {
                Console.WriteLine(ele[front] + " dequeued from queue");
                T p = ele[front++];
                Console.WriteLine();
                Console.WriteLine("Front item is {0}", ele[front]);
                Console.WriteLine("Rear item is {0} ", ele[rear]);
                return p;
            }
        }
    }   
}