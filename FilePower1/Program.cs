using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FilePower1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = $"FilePower1/{args[0]}";
            Queue<string> queue = new Queue<string>();            
            string input = "Start!";
            while (input != "")
            {
                input = Console.ReadLine();
                queue.Enqueue(input);
            }
            File.WriteAllLines(path, queue);
        }
    }
}
