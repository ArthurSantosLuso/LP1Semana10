using System;
using System.IO;

namespace CharSets
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (string filePath in args)
            {
                using (StreamReader sr = new StreamReader(filePath))
                {

                }
            }
        }
    }
}
