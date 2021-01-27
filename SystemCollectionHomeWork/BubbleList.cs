using System;
using System.Collections.Generic;
using System.Text;

namespace SystemCollectionHomeWork
{
    class BubbleList<T> : List<T>
    {
        private class Node
        {
            public Node Next;
            public int Data;
        }

        private Node head = null;

        public int Size()
        {
            int listsize = 0;
            Node current = head;
            while (current != null)
            {
                listsize++;
                current = current.Next;
            }
            return listsize;
        }

        public void OrderListBubbleAlgoritm()
        {
            Node current = head;
            for (int i = 1; i < Size()-1; i++)
            {
                for (int j = 0; j < Size() - 1; j++)
                {
                    if (current.Data > current.Next.Data && current.Next != null)
                    {
                        int temp = current.Data;
                        current.Data = current.Next.Data;
                        current.Next.Data = temp;
                    }

                }
            }
            head = current.Next;           
        }
    }
}
