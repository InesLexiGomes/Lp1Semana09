using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace IntCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {1, 10,-30, 10,-5};
            Stack<int> stack = new Stack<int>(list);
            Queue<int> queue = new Queue<int>(list);
            HashSet<int> hash = new HashSet<int>(list);

            Console.Write("List:");
            foreach (int i in list)
            {
                Console.Write($" {i},");
            }
            Console.WriteLine("");

            Console.Write("Stack:");
            foreach (int i in stack)
            {
                Console.Write($" {i},");
            }
            Console.WriteLine("");

            Console.Write("Queue:");
            foreach (int i in queue)
            {
                Console.Write($" {i},");
            }
            Console.WriteLine("");

            Console.Write("HashSet:");
            foreach (int i in hash)
            {
                Console.Write($" {i},");
            }
            Console.WriteLine("");

        }
    }
}
