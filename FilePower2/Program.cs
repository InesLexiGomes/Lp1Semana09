using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FilePower2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = $"FilePower2/{args[0]}";
            StreamWriter sw = new StreamWriter(path);

            string input = Console.ReadLine();
            while (input != "")
            {
                sw.WriteLine(input);
                input = Console.ReadLine();
            }
            sw.Close();
        }
    }
}
