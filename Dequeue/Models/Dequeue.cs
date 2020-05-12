using System;
using System.Collections;
using System.Collections.Generic;

namespace Dequeue.Models
{
    public class Dequeue<T> : IEnumerable<T>
    {
        public Dequeue()
        {

        }
        DoublyNode<T> head;
        DoublyNode<T> tail;
        int count;
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void AddLast(T data)
        {
            var node = new DoublyNode<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }

            tail = node;
            count++;
        }

        public void AddFirst(T data)
        {
            var node = new DoublyNode<T>(data);
            var temp = head;
            node.Next = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.Previous = node;
            count++;
        }

        public T RemoveFirst()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = head.Data;
            if (count == 1)
            {
                head = tail = null;
            }
            else
            {
                head = head.Next;
                head.Previous = null;
            }
            count--;
            return output;
        }
        public T RemoveLast()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = tail.Data;
            if (count == 1)
            {
                head = tail = null;
            }
            else
            {
                tail = tail.Previous;
                tail.Next = null;
            }
            count--;
            return output;
        }
        public T First
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return head.Data;
            }
        }
        public T Last
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return tail.Data;
            }
        }
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            DoublyNode<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}

