namespace DoubleLinkedList.Model
{
    public class DoubleNode<T>
    {
        public DoubleNode(T data)
        {
            Data = data;
        }

        public T Data { get; }
        public DoubleNode<T> Next { get; set; }
        public DoubleNode<T> Previous { get; set; }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
