using NUnit.Framework;
using AlgorithumsAndDataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithumsAndDataStructures.Tests
{
    [TestFixture()]
    public class SortTests
    {

        [Test()]
        public void QuickSortTest()
        {
            int[] numbers = new int[new Random().Next(5, 20)];
            int[] SortedNumbers = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(100);
            }
            Array.Copy(numbers, SortedNumbers, numbers.Length);

            AlgorithumsAndDataStructures.Sorts.QuickSort(numbers, 0, numbers.Length - 1);

            Array.Sort(SortedNumbers);

            Assert.AreEqual(numbers, SortedNumbers);

        }
    
        //bubble sort
        [Test()]
        public void SortBubbleTest()
        {
            int[] numbers = new int[new Random().Next(5, 20)];
            int[] SortedNumbers = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(100);
            }
            Array.Copy(numbers, SortedNumbers, numbers.Length);

            numbers= AlgorithumsAndDataStructures.Sorts.SortBubble(numbers);

            Array.Sort(SortedNumbers);

            Assert.AreEqual(numbers, SortedNumbers);
        }
        
        //insertion sort
            [Test()]
        public void InsertionSortTest()
        {
            int[] numbers = new int[new Random().Next(5, 20)];
            int[] SortedNumbers = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(100);
            }
            Array.Copy(numbers, SortedNumbers, numbers.Length);

            numbers= AlgorithumsAndDataStructures.Sorts.InsertionSort(numbers);

            Array.Sort(SortedNumbers);

            Assert.AreEqual(numbers, SortedNumbers);
        }

        //Radix sort
        [Test()]
        public void Radix_SortTest()
        {
            int[] numbers = new int[new Random().Next(5, 20)];
            int[] SortedNumbers = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(100);
            }
            Array.Copy(numbers, SortedNumbers, numbers.Length);

            numbers = AlgorithumsAndDataStructures.Sorts.RadixSort(numbers);

            Array.Sort(SortedNumbers);

            Assert.AreEqual(numbers, SortedNumbers);
        }


        
        //binary search
        [Test()]
        public void BinarySearchTestContains()
        {
            int[] numbers = new int[new Random().Next(5, 20)];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(100);
            }
            Array.Sort(numbers);
            
            int numTofind = numbers[new Random().Next(numbers.Length)];
            Assert.IsTrue(AlgorithumsAndDataStructures.Sorts.BinarySearch(numTofind, numbers));
        }

        [Test()]
        public void BinarySearchTestNotContains()
        {
            int[] numbers = new int[new Random().Next(5, 20)];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 1;
            }
            Array.Sort(numbers);
            
            Assert.That(() => AlgorithumsAndDataStructures.Sorts.BinarySearch(2, numbers), Throws.Nothing);
            Assert.IsFalse(AlgorithumsAndDataStructures.Sorts.BinarySearch(2, numbers));
        }


    }
}