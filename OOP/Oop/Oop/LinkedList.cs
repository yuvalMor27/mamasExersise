using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    class LinkedList

    {
        private Node _head;
        private Node _lastNode;

        public LinkedList(int value)
        {
            _head = new Node(value);
            _lastNode = _head;
        }

        private Node _GetNodeAt(int index)
        {
            Node node = this._head;
            int i = 0;
            while (i++ < index )
            {
                node = node.Next;
            }
            return node;
        }

        public void Append(int value)
        {
            Node newNode = new Node(value);
            _lastNode.Next = newNode;
            _lastNode = newNode;
        }

        public void Prepend(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = _head;
            _head = newNode;
        }

        public int Pop()
        {
            int index = 0;
            Node current_node = _head;
            while (current_node!= null)
            {
                current_node = current_node.Next;
                index += 1;
            }
            Node beforeLast = _GetNodeAt(index-1);
            beforeLast.Next = null;
            _lastNode = beforeLast;
            return _lastNode.Value;
        }

        public int Unqueue()
        {
            Node current_node = _head;
            int headVal = _head.Value;
            _head = current_node.Next;
            return headVal;
        }

        public IEnumerable<int> ToList()
        {
            List<int> list = new List<int>();
            Node current_node = _head;
            Node head = _head;
            while (head != null)
            {
                list.Add(head.Value);
                head = head.Next;
            }
            IEnumerable<int> numberEnumerable = list;
            return numberEnumerable;
        }
    }
}
