using System;
using StackBasedOnLinkedList.Models;

namespace StackBasedOnLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new NodeStack<string>();

            stack.Push("Tom");
            stack.Push("Alice");
            stack.Push("Bob");
            stack.Push("Kate");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            string header = stack.Peek();
            Console.WriteLine($"Верхушка стека: {header}");
            Console.WriteLine();

            header = stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
