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
            public void push(int element)
            {
                Node fresh;
                fresh = new Node(element, null);

                fresh.next = top;
                top = fresh;
                Console.WriteLine("\n" + element + "pushed.");

            }
        }
        static void Main(string[] args)
        {
        }
    }
}
