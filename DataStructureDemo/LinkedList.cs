using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureDemo
{
    class LinkedList
    {
        internal Node head;

        internal void addatBeginning(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                node.next = null;
            else
                node.next = this.head;
            this.head = node;
            Console.WriteLine("{0} is inserted at the head ", node.data);
        }

        public void addAtEnd(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} is inserted into the linked list", node.data);
        }
    }
}
