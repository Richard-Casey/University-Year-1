using NUnit.Framework;
using AlgorithumsAndDataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithumsAndDataStructures.Tests
{
    [TestFixture()]
    public class TreeTests
    {
        [Test()]
        public void SearchTreeContains()
        {

            AlgorithumsAndDataStructures.BinalryTree BinaryTree = new BinalryTree();


            for (int i = 0; i < new Random().Next(100); i++)
            {
                BinaryTree.Insert(new Random().Next(100));
            }

            BinaryTree.Insert(10);

            bool b =BinaryTree.Search(10).Data == 10;
            Assert.IsTrue(b);
        }

        [Test()]
        public void SearchTreeNotContains()
        {

            AlgorithumsAndDataStructures.BinalryTree BinaryTree = new BinalryTree();


            for (int i = 0; i < new Random().Next(100); i++)
            {
                BinaryTree.Insert(i);
            }

            Assert.That(() => BinaryTree.Search(101), Throws.Nothing);
            bool b = BinaryTree.Search(10).Data == 101;
            Assert.IsFalse(b);
        }
    }

    [TestFixture()]
    public class HeapTests
    { 


        [Test()]
        public void MinimumHeapGetMin()
        {
            AlgorithumsAndDataStructures.MinHeap heap = new MinHeap(50);

            const int MaxVal = 100;
            int min = MaxVal;
            for (int i = 0; i < new Random().Next(50); i++)
            {
                int newValue = new Random().Next(MaxVal);
                if (newValue < min)
                    min = newValue;
                    
                heap.Insert(newValue);
            }

            int result = heap.getMin();
            Assert.AreEqual(min, result);

        }


    }
    
}

