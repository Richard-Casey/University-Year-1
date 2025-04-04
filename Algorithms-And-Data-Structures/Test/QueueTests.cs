using NUnit.Framework;
using AlgorithumsAndDataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithumsAndDataStructures.Tests
{
    [TestFixture()]
    public class QueueTests
    {
        [Test()]
        public void EnqueueTest()
        {
            AlgorithumsAndDataStructures.Queue<int> Q = new Queue<int>(100);
            for (int i = 0; i < new Random().Next(50); i++)
            {
                Q.Enqueue(i);
            }
            Assert.That(() => Q.Peek(), Throws.Nothing);
            Assert.AreEqual(0, Q.Peek());
        }

        [Test()]
        public void DequeueTest()
        {
            AlgorithumsAndDataStructures.Queue<int> Q = new Queue<int>(100);
            int Count = 0;
            for (int i = 0; i < new Random().Next(50); i++)
            {
                Q.Enqueue(i);
                Count++;
            }

            for (int i = 0; i < Count; i++)
            {
                Assert.AreEqual(i, Q.Dequeue());
            }
        }
    }
}