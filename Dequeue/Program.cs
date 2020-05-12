using System;

namespace Dequeue
{
    class Program
    {
        static void Main(string[] args)
        {
            var usersDeck = new Models.Dequeue<string>();
            usersDeck.AddFirst("Alice");
            usersDeck.AddLast("Kate");
            usersDeck.AddLast("Tom");

            foreach (string s in usersDeck)
                Console.WriteLine(s);

            string removedItem = usersDeck.RemoveFirst();
            Console.WriteLine("\n Removed: {0} \n", removedItem);

            foreach (string s in usersDeck)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
