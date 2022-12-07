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
            stacks s = new stacks();
            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stack Menu***\n");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("$. Exit");
                Console.Write("\nEnter Your Choice :");
                string sInput = Console.ReadLine();
                char ch -Convert.ToChar(sInput-- "" ? "0" : sInput);
            }
        }
    }
}
