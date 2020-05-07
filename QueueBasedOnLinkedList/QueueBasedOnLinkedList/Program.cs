using System;
using QueueBasedOnLinkedList.Models;

namespace QueueBasedOnLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();
            queue.Enqueue("Kate");
            queue.Enqueue("Sam");
            queue.Enqueue("Alice");
            queue.Enqueue("Tom");

            foreach (string item in queue)
                Console.WriteLine(item);
            Console.WriteLine();

            Console.WriteLine();
            queue.Dequeue();
            // Console.WriteLine($"Извлеченный элемент: {firstItem}");
            Console.WriteLine();

            foreach (string item in queue)
                Console.WriteLine(item);
        }
    }
}
