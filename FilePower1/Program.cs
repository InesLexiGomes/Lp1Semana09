using System;
using System.Collections.Generic;

namespace FilePower1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();            
            string input = "Start!"
            while (input != "")
            {
                input = Console.ReadLine();
                queue.Enqueue(input);
            }
        }
    }
}
