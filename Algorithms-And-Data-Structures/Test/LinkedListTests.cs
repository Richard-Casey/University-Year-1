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
    public class LinkedListTests
    {
        [Test()]
        public void AddToEndOfListTest()
        {
            AlgorithumsAndDataStructures.LinkedList<int> list = new LinkedList<int>();
            
            list.AddToEndOfList(1);
            list.AddToEndOfList(2);
            list.AddToEndOfList(3);
            list.AddToEndOfList(4);
            
            Assert.AreEqual(4, list.GetDataAtTail());
        }

        [Test()]
        public void DeleteAtIndexTest()
        {
            AlgorithumsAndDataStructures.LinkedList<int> list = new LinkedList<int>();

            list.AddToEndOfList(1);
            list.AddToEndOfList(2);
            list.AddToEndOfList(3);
            list.AddToEndOfList(4);

            list.DeleteAtIndex(1);

            Assert.That(() => list.GetDataAtIndex(1), Throws.Nothing);
            Assert.AreNotEqual(2, list.GetDataAtIndex(1));
           
        }

        [Test()]
        public void MoveNodeUpOnePlaceTest()
        {
            AlgorithumsAndDataStructures.LinkedList<int> list = new LinkedList<int>();

            list.AddToEndOfList(1);
            list.AddToEndOfList(2);
            list.AddToEndOfList(3);
            list.AddToEndOfList(4);

            list.MoveNodeUpOnePlace(1);


            Assert.AreEqual(2, list.GetDataAtIndex(0));
            Assert.AreEqual(1, list.GetDataAtIndex(1));
        }

        [Test()]
        public void MoveNodeDownOnePlaceTest()
        {
            AlgorithumsAndDataStructures.LinkedList<int> list = new LinkedList<int>();

            list.AddToEndOfList(1);
            list.AddToEndOfList(2);
            list.AddToEndOfList(3);
            list.AddToEndOfList(4);

            list.MoveNodeDownOnePlace(0);


            Assert.AreEqual(2, list.GetDataAtIndex(0));
            Assert.AreEqual(1, list.GetDataAtIndex(1));
        }

        [Test()]
        public void InsertAtIndex0Test()
        {
            AlgorithumsAndDataStructures.LinkedList<int> list = new LinkedList<int>();

            list.AddToEndOfList(1);
            list.AddToEndOfList(2);
            list.AddToEndOfList(3);
            list.AddToEndOfList(4);

            list.InsertAtIndex(0,20);


            Assert.AreEqual(20, list.GetDataAtHead());
        }

        [Test()]
        public void DeleteLastNodeTest()
        {
            AlgorithumsAndDataStructures.LinkedList<int> list = new LinkedList<int>();

            list.AddToEndOfList(1);
            list.AddToEndOfList(2);
            list.AddToEndOfList(3);
            list.AddToEndOfList(4);

            list.DeleteLastNode();

            Assert.That(() => list.GetDataAtTail(), Throws.Nothing);
            Assert.AreNotEqual(4, list.GetDataAtTail());
        }

    }
}