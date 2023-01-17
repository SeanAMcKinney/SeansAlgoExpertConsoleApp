using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeansAlgoExpertConsoleApp
{
    public class SingleLinkedListCreator
    {
        internal class Node
        {
            internal int data;
            internal Node? next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        internal class SingleLinkedList
        {
            internal Node head;


            internal void InsertFront(SingleLinkedList singlyList, int new_data)
            {
                Node new_node = new Node(new_data);
                new_node.next = singlyList.head;
                singlyList.head = new_node;
            }

            internal void InsertLast(SingleLinkedList singlyList, int new_data)
            {
                Node new_node = new Node(new_data);
                if (singlyList.head == null)
                {
                    singlyList.head = new_node;
                    return;
                }
                Node lastNode = GetLastNode(singlyList);
                lastNode.next = new_node;
            }

            internal Node GetLastNode(SingleLinkedList singlyList)
            {
                Node temp = singlyList.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                return temp;
            }

            internal void InsertAfter(Node prev_node, int new_data)
            {
                if (prev_node == null)
                {
                    Console.WriteLine("The given previous node Cannot be null");
                    return;
                }
                Node new_node = new Node(new_data);
                new_node.next = prev_node.next;
                prev_node.next = new_node;
            }
        }
    }
}
