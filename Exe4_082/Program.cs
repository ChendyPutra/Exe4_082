﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_082
{
    internal class Program
    {
        class Node
        {
            public int info;
            public Node next;
            public Node(int i, Node n)
            {
                info = i;
                next = n;
            }
        }
        class stacks
        {
            Node top;

            public stacks()
            {
                top null;
            }
            bool empty()
            {
                if (top == null)
                    return (true);
                else
                    return (false);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
