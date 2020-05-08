using System.Collections;

namespace LinkedList.Models
{
    public class LinkedList<T> : IEnumerable
    {
        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        public int Count { get; private set; }

        public void Add(T data)
        {
            var nodeToAdd = new Node<T>(data);

            if (Head == null)
            {
                Head = nodeToAdd;
                Tail = nodeToAdd;
            }
            else
            {
                Tail.Next = nodeToAdd;
                Tail = nodeToAdd;
            }

            Count++;
        }

        public void Delete(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head.Next;
                var previous = Head;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                    }

                    previous = current;
                    current = current.Next;
                }

            }
        }

        public IEnumerator GetEnumerator()
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
