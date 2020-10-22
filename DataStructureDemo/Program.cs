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
            list.display();
        }
    }
}
