using System;
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
                Node top;
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
            public void pop()
            {
                Console.WriteLine("\nThe Popped element is:" + top.info);
                top = top.next;
            }
            public void display()
            {
                Node tmp;

                if (empty())
                    Console.WriteLine("Stack Empty");
                else
                {
                    for (tmp = top; tmp != null; tmp = tmp.next)
                    {
                        Console.WriteLine(tmp.info);
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
