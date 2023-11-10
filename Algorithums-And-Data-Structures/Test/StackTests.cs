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
    public class StackTests
    {
        [Test()]
        public void PushTest()
        {
            AlgorithumsAndDataStructures.Stack<int> stack = new Stack<int>();

            for (int i = 0; i < new Random().Next(50); i++)
            {
                stack.Push(i);
                Assert.AreEqual(i, stack.Peek());
            }
            
            
        }

        [Test()]
        public void PopTest()
        {
            AlgorithumsAndDataStructures.Stack<int> stack = new Stack<int>();
            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);
            }
            
            Assert.AreEqual(4, stack.Pop());
            Assert.AreEqual(3, stack.Peek());
        }
    }
}