using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string fileName = args[0];
            Queue<string> inputQueue = new Queue<string>();

            Console.WriteLine("");

            while (true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                    break;

                inputQueue.Enqueue(input);
            }

            File.WriteAllLines(fileName, inputQueue);
        }
    }
}