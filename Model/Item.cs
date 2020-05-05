using System.Collections;

namespace LinkedList.Model
{
    /// <summary>
    /// Ячейка списка
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Item<T> 
    {
        public Item(T data)
        {
            Data = data;
        }
        /// <summary>
        /// Данные, хранимые в ячейке списка.
        /// </summary>
        private T data;

        /// <summary>
        /// Следующая ячейка списка
        /// </summary>
        public Item<T> Next { get; set; } = null;
        public T Data
        {
            get => data;
            set
            {
                if (value != null)
                {
                    data = value;
                }
            }
        }

        public override string ToString()
        {
            return Data.ToString();
        }

    }
}
