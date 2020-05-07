using System;
using System.Collections;

namespace QueueBasedOnLinkedList.Models
{
    public class Queue<T> : IEnumerable
    {
        private Node<T> head;
        private Node<T> tail;
        private int count;

        public void Enqueue(T data)
        {
            var node = new Node<T>(data);
            var tempNode = tail;
            tail = node;
            if (count == 0)
            {
                head = tail;
            }
            else
            {
                tempNode.Next = tail;
            }
            count++;
        }

        public void Dequeue()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Queue is empty!");
            }
            if (head.Next != null)
            {
                head = head.Next;
            }
            else
            {
                head = null;
                tail = null;
            }

            count--;
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
