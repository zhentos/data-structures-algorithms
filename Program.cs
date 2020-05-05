﻿using System;

namespace LinkedList
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var list = new Model.LinkedList<int>
            {
                1,
                2,
                3,
                4,
                5
            };

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.Delete(3);
            list.Delete(1);
            list.Delete(7);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.AppendHead(7);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
