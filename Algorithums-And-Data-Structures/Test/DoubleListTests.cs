using NUnit.Framework;
using AlgorithumsAndDataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithumsAndDataStructures.Tests
{
    [TestFixture()]
    public class DoubleListTests
    {
        [Test()]
        public void AddToEndOfListTest()
        {
            DoubleList<int> DDL = new DoubleList<int>();
            DDL.AddToEndOfList(1);
            DDL.AddToEndOfList(2);
            DDL.AddToEndOfList(3);
            DDL.AddToEndOfList(4);
            DDL.AddToEndOfList(5);
            
            Assert.AreEqual( 5, DDL.GetDataAtTail());
        }

        [Test()]
        public void InsertAtIndex0Test()
        {
            DoubleList<int> DDL = new DoubleList<int>();
            DDL.AddToEndOfList(1);
            DDL.AddToEndOfList(2);
            DDL.AddToEndOfList(3);
            DDL.AddToEndOfList(4);
            DDL.AddToEndOfList(5);
            DDL.InsertAtIndex(15, 0);

            Assert.AreEqual(15, DDL.GetDataAtIndex(0));
        }
        public void InsertAtIndex5Test()
        {
            DoubleList<int> DDL = new DoubleList<int>();
            DDL.AddToEndOfList(1);
            DDL.AddToEndOfList(2);
            DDL.AddToEndOfList(3);
            DDL.AddToEndOfList(4);
            DDL.AddToEndOfList(5);
            DDL.AddToEndOfList(6);
            DDL.InsertAtIndex(15, 5);

            Assert.AreEqual(15, DDL.GetDataAtIndex(5));
        }

        [Test()]
        public void DeleteByDataTest()
        {
            DoubleList<int> DDL = new DoubleList<int>();
            DDL.AddToEndOfList(1);
            DDL.AddToEndOfList(2);
            DDL.AddToEndOfList(3);
            DDL.AddToEndOfList(4);
            DDL.AddToEndOfList(5);
            
            DDL.DeleteAtIndex(1);
            Assert.That(() => DDL.GetDataAtIndex(1), Throws.Nothing);
            Assert.AreNotEqual(2, DDL.GetDataAtIndex(1));
        }

        [Test()]
        public void DeleteLastNodeTest()
        {
            DoubleList<int> DDL = new DoubleList<int>();
            DDL.AddToEndOfList(1);
            DDL.AddToEndOfList(2);
            DDL.AddToEndOfList(3);
            DDL.AddToEndOfList(4);
            DDL.AddToEndOfList(5);

            DDL.DeleteLastNode();
            Assert.That(() => DDL.GetDataAtTail(), Throws.Nothing);
            Assert.AreNotEqual(5, DDL.GetDataAtTail());
        }

        [Test()]
        public void MoveNodeUpOnePlaceTest()
        {
            DoubleList<int> DDL = new DoubleList<int>();
            DDL.AddToEndOfList(1);
            DDL.AddToEndOfList(2);
            DDL.AddToEndOfList(3);
            DDL.AddToEndOfList(4);
            DDL.AddToEndOfList(5);

            DDL.MoveNodeUpOnePlace(1);
            Assert.AreEqual(2, DDL.GetDataAtIndex(0),"Head is not 2");
            Assert.AreEqual(1, DDL.GetDataAtIndex(1), "index 1 is not 1");
        }

        [Test()]
        public void MoveNodeDownOnePlaceTest()
        {
            DoubleList<int> DDL = new DoubleList<int>();
            DDL.AddToEndOfList(1);
            DDL.AddToEndOfList(2);
            DDL.AddToEndOfList(3);
            DDL.AddToEndOfList(4);
            DDL.AddToEndOfList(5);

            DDL.MoveNodeDownOnePlace(1);
            Assert.AreEqual(3, DDL.GetDataAtIndex(1), "Head is not 3");
            Assert.AreEqual(2, DDL.GetDataAtIndex(2), "index 3 is not 2");
        }
    }
}