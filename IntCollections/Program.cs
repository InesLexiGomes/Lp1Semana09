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

            string s = "List:";
            foreach (int i in list)
            {
                s = $"{s} {i},";
            }
            Console.WriteLine(s);
            
            s = "Stack:";
            foreach (int i in stack)
            {
                s = $"{s} {i},";
            }
            Console.WriteLine(s);

            s = "Queue:";
            foreach (int i in queue)
            {
                s = $"{s} {i},";
            }
            Console.WriteLine(s);

            s = "Hash Set:";
            foreach (int i in hash)
            {
                s = $"{s} {i},";
            }
            Console.WriteLine(s);

        }
    }
}
