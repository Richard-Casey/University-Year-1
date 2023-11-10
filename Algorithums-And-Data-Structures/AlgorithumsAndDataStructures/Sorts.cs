using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithumsAndDataStructures
{
    public class Sorts
    {

        public static int getMax(int[] unSortedData, int ArraySize)
        {
            int mx = unSortedData[0];
            for (int i = 1; i < ArraySize; i++)
                if (unSortedData[i] > mx)
                    mx = unSortedData[i];
            return mx;
        }

        public static void countSort(int[] arr, int n, int exp)
        {
            int[] output = new int[n];
            int i;
            int[] count = new int[10];


            for (i = 0; i < 10; i++)
                count[i] = 0;

            for (i = 0; i < n; i++)
                count[(arr[i] / exp) % 10]++;

            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];

            for (i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

            for (i = 0; i < n; i++)
                arr[i] = output[i];
        }

        static void swap(int[] numbersToSort, int i, int j)
        {
            int temp = numbersToSort[i];
            numbersToSort[i] = numbersToSort[j];
            numbersToSort[j] = temp;
        }


        static int partition(int[] numbersToSort, int leftside, int rightSide)
        {
            int pivot = numbersToSort[rightSide];
            int i = (leftside - 1);

            for (int j = leftside; j <= rightSide - 1; j++)
            {
                if (numbersToSort[j] < pivot)
                {
                    i++;
                    swap(numbersToSort, i, j);
                }
            }
            swap(numbersToSort, i + 1, rightSide);
            return (i + 1);

        }

        public static void QuickSort(int[] numbersToSort, int leftSide, int rightSide)
        {
            if (leftSide < rightSide)
            {
                int pi = partition(numbersToSort, leftSide, rightSide);

                QuickSort(numbersToSort, leftSide, pi - 1);
                QuickSort(numbersToSort, pi + 1, rightSide);

            }

        }

        public static int[] SortBubble(int[] unsortedBubble)
        {
            int n = unsortedBubble.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                {
                    int NextJ = j + 1;
                    if (unsortedBubble[j] > unsortedBubble[NextJ])
                    {
                        int temp = unsortedBubble[j];
                        unsortedBubble[j] = unsortedBubble[NextJ];
                        unsortedBubble[NextJ] = temp;
                    }
                }
            return unsortedBubble;


        }

        public static int[] InsertionSort(int[] UnsortedData)
        {
            
            int n = UnsortedData.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = UnsortedData[i];
                int j = i - 1;

                while (j >= 0 && UnsortedData[j] > key)
                {
                    UnsortedData[j + 1] = UnsortedData[j];
                    j = j - 1;
                }
                UnsortedData[j + 1] = key;
            }
            
            return UnsortedData;
        }

        public static int[] RadixSort(int[] unSortedData)
        {
            int m = getMax(unSortedData, unSortedData.Length);
            for (int exp = 1; m / exp > 0; exp *= 10)
                countSort(unSortedData, unSortedData.Length, exp);

            return unSortedData; // its actualy sorted at this point
        }


        public static bool BinarySearch(int SearchingFor, int[] Data)
        {
            return BinSearch(Data, SearchingFor, 0, Data.Length);
        }

        private static Boolean BinSearch(int[] data, int SearchingFor, int low, int high)
        {
            int mid = (low + high) / 2;

            if (low >= high) return false;

            if (data[mid] == SearchingFor) return true;

            Boolean foundleft = BinSearch(data, SearchingFor, low, mid);
            Boolean foundright = !foundleft && BinSearch(data, SearchingFor, mid + 1, high);

            return foundleft || foundright;
        }
    }
}
