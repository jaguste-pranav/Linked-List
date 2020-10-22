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
    }
}
