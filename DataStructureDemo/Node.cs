﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureDemo
{
    class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
}
