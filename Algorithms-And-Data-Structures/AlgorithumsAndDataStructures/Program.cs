using System;

namespace AlgorithumsAndDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test your code here");
            //Console.ReadLine(); // pause console (do not leave these in you final code!)
            //Binary tree
            BinalryTree BinarytreeTest = new AlgorithumsAndDataStructures.BinalryTree();

            BinarytreeTest.Insert(2);
            BinarytreeTest.Insert(1);
            BinarytreeTest.Insert(3);
            BinarytreeTest.Insert(4);
            BinarytreeTest.Insert(5);
            BinarytreeTest.Insert(6);
            BinarytreeTest.Insert(7);
            BinarytreeTest.Insert(8);

            int i = 0;


            //List
            /*LinkedList<int> ll = new LinkedList<int>();
            ll.AddToEndOfList(12);
            ll.AddToEndOfList(22);
            ll.AddToEndOfList(7);
            ll.DeleteAtIndex(2);
            ll.AddToEndOfList(69);
            ll.AddToEndOfList(111);
            ll.AddToEndOfList(71); // List is now 12,22,69,111,71
            ll.MoveNodeUpOnePlace(4); // List is now 12,22,69,71,111
            ll.MoveNodeDownOnePlace(2); // List is now 12,22,71,69,111
            ll.InsertAtIndex(14, 3); // List is now 12,22,71,14,69,111
            ll.DeleteLastNode(); // List is now 12,22,71,14,69*/

            //Console.ReadLine();

            //Double Linked List
            /*DoubleList<int> dl = new DoubleList<int>();

            dl.AddToEndOfList(11);
            dl.AddToEndOfList(4);
            dl.AddToEndOfList(7);
            dl.AddToEndOfList(19);
            dl.AddToEndOfList(2);
            dl.AddToEndOfList(6); 
            dl.InsertAtIndex(88, 4); // List as of this point 11, 4, 7, 19, 88, 2, 6
            dl.DeleteAtIndex(2); // List as of this point is 11, 4, 19, 88, 2, 6
            dl.DeleteLastNode(); // List is now 11, 4, 19, 88, 2
            dl.MoveNodeUpOnePlace(2); // List is now 11, 19, 4, 88, 2
           dl.MoveNodeDownOnePlace(2); // List now 11, 19, 88, 4, 2
            
            //Console.WriteLine(dl.GetDataAtIndex(2)); // This should display 88
            //Console.WriteLine(dl.GetDataAtHead()); // This should display 11
            //Console.WriteLine(dl.GetDataAtTail()); // This should display 2


            
            Console.ReadLine();*/
            //Minimum Heap



            //Queue
            /* Queue<int> qu = new Queue<int>(5);
             qu.Enqueue(1);
             qu.Enqueue(2);
             qu.Enqueue(3);
             qu.Enqueue(4);
             qu.Enqueue(5);
             Console.WriteLine(qu.Peek());
             qu.Dequeue();
             Console.WriteLine(qu.Peek());

             Console.ReadLine();*/


            //Stack
            /*Stack<int> st = new Stack<int>();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push(5);

            for (int i = 0; i < 5; i++)
                Console.Out.Write(st.Pop()+", ");


            int STOPHERE = 345345;*/


            //Sort



            //quick sort


            //bubble sort
            int[] numbers = new int[5];
            //int[] SortedNumbers = new int[numbers.Length];
            for ( i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(10);
            }
            ///Array.Copy(numbers, SortedNumbers, numbers.Length);

            numbers = AlgorithumsAndDataStructures.Sorts.SortBubble(numbers);
            int b = 0;
            //insertion sort


            //radix


            //Binary sort search


            //Traveling sails man

        }
    }
}

