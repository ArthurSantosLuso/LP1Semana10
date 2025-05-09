using System;
using System.IO;

namespace FilePower2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string fileName = args[0];

            Console.WriteLine("");

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                while (true)
                {
                    string input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input))
                        break;

                    writer.WriteLine(input);
                }
            }
        }
    }
}
