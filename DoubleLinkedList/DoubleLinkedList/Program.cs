using System;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var dn = new Model.DoubleLinkedList<int>();
            dn.Add(1);
            dn.Add(2);
            dn.AddFirst(0);

            foreach (var node in dn)
            {
                Console.Write(node + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
