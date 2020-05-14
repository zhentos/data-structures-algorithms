using System;
using System.Collections;

namespace StackBasedOnLinkedList.Models
{
    public class NodeStack<T> : IEnumerable
    {
        private Node<T> head;
        private int count;

        public bool IsEmpty => count == 0;
        public int Count => count;

        public void Push(T item)
        {
            var node = new Node<T>(item);
            node.Next = head;
            head = node;
            count++;
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Stack is empty!");
            }

            var item = head;
            head = head.Next;
            count--;
            return item.Data;
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            return head.Data;
        }

        public IEnumerator GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
