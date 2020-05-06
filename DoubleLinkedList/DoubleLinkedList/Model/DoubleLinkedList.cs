using System.Collections;
using System.Collections.Generic;

namespace DoubleLinkedList.Model
{
    public class DoubleLinkedList<T> : IEnumerable<T>
    {
        public DoubleNode<T> Head { get; set; }

        public DoubleNode<T> Tail { get; set; }
        public int Count { get; private set; }

        public void Add(T data)
        {
            var node = new DoubleNode<T>(data);
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
            }

            Tail = node;
            Count++;
        }
        public bool Remove(T data)
        {
            var current = Head;

            // поиск удаляемого узла
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    break;
                }
                current = current.Next;
            }
            if (current != null)
            {
                // если узел не последний
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    // если последний, переустанавливаем tail
                    Tail = current.Previous;
                }

                // если узел не первый
                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    // если первый, переустанавливаем head
                    Head = current.Next;
                }
                Count--;
                return true;
            }
            return false;
        }

        public void AddFirst(T data)
        {
            var node = new DoubleNode<T>(data);
            var temp = Head;

            node.Next = Head;
            Head = node;
            if (Count == 0)
            {
                Tail = Head;
            }
            else
            {
                temp.Previous = node;
            }

            Count++;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
