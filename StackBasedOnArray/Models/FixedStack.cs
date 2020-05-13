using System;

namespace StackBasedOnArray.Models
{
    public class FixedStack<T>
    {
        private T[] items;
        private int defaultSize = 10;
        private int _count;
        public FixedStack()
        {
            items = new T[defaultSize];
        }

        public bool IsEmpty
        {
            get { return _count == 0; }
        }
        public FixedStack(int newSize)
        {
            items = new T[newSize];
        }

        public int GetStackSizeCount
        {
            get { return _count; }
        }

        public void Push(T data)
        {
            if (GetStackSizeCount == items.Length)
            {
                throw new InvalidOperationException("Stack Overflow");
            }

            items[_count++] = data;
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T item = items[--_count];
            items[_count] = default(T);
            return item;
        }

        // возвращаем элемент из верхушки стека
        public T Peek()
        {
            return items[_count - 1];
        }
    }
}
