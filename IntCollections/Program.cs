using System;
using System.Collections.Generic;

namespace IntCollections
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = { 1, 10, -30, 10, -5 };

            List<int> list = new List<int> { 1, 10, -30, 10, -5 };
            HashSet<int> hashSet = new HashSet<int> { 1, 10, -30, 10, -5 };
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();

            foreach (int num in numbers)
            {
                stack.Push(num);
                queue.Enqueue(num);
            }

            Console.WriteLine("List:");
            foreach (int valor in list)
            {
                Console.WriteLine(valor);
            }

            Console.WriteLine("Stack:");
            foreach (int valor in stack)
            {
                Console.WriteLine(valor);
            }

            Console.WriteLine("Queue:");
            foreach (int valor in queue)
            {
                Console.WriteLine(valor);
            }

            Console.WriteLine("HashSet:");
            foreach (int valor in hashSet)
            {
                Console.WriteLine(valor);
            }
        }
    }
}
