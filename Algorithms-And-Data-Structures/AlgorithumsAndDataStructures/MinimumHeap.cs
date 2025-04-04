using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithumsAndDataStructures
{
    public class MinHeap // Binary Minimum Heap
    {

        public int[] heapArray { get; set; }
        public int capacity { get; set; }
        public int currentHeapSize { get; set; }


        public MinHeap (int n)
        {
            capacity = n;
            heapArray = new int[capacity];
            currentHeapSize = 0;
        }

        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        public int Parent (int key)
        {
            return (key - 1) / 2;
        }

        public int Left (int key)
        {
            return 2 * key + 1;
        }

        public int Right (int key)
        {
            return 2 * key + 2;
        }


     
        public bool Insert(int key)
        {
            if (currentHeapSize == capacity)
            {
                return false;
            }

            int i = currentHeapSize;
            heapArray[i] = key;
            currentHeapSize++;

            while (i != 0 && heapArray[i] <
                     heapArray[Parent(i)])
            {
                Swap(ref heapArray[i],
                     ref heapArray[Parent(i)]);
                i = Parent(i);
            }
            return true;
        }

           


        public int getMin()
        {
            return heapArray[0];
        }

    }
}
