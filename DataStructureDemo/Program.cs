using System;

namespace DataStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List application");
            LinkedList list = new LinkedList();
            list.addAtEnd(3);
            list.addAtEnd(43);
            list.addAtEnd(51);

            list.insertInGivenPosition(2, 50);
            list.removeFirstElement();
            list.addAtEnd(89);
            list.addAtEnd(6);
            list.addAtEnd(75);
            list.addAtEnd(24);
            list.removeFirstElement();

            list.display();
            list.DeleteWithValue(51);
            list.display();
            Console.WriteLine("The position is "+list.findData(111));
        }
    }
}
