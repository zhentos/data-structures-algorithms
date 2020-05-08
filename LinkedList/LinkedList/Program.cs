using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = new Models.LinkedList<int>
            {
                1,
                2,
                3,
                4,
                5
            };


            foreach (var node in m)
            {
                Console.Write(node + " ");
            }
            Console.WriteLine();

            m.Delete(3);

            foreach (var node in m)
            {
                Console.Write(node + " ");
            }
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
