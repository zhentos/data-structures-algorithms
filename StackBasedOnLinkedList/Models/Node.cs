using System;
using System.Collections.Generic;
using System.Text;

namespace StackBasedOnLinkedList.Models
{
    public class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
