using System;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>(
                Console.ReadLine().Split(", ").Select(int.Parse).ToList());

            Queue<int> threads = new Queue<int>(
                Console.ReadLine().Split(" ").Select(int.Parse).ToList());

            int taskToBeKilled = int.Parse(Console.ReadLine());

            while (tasks.Count > 0 && threads.Count > 0)
            {
                if (tasks.Peek() == taskToBeKilled)
                {
                    Console.WriteLine($"Thread with value {threads.Peek()} killed task {taskToBeKilled}");
                    break;
                }

                if (threads.Peek() >= tasks.Peek())
                {
                    threads.Dequeue();
                    tasks.Pop();
                }
                else if (threads.Peek() < tasks.Peek())
                {
                    threads.Dequeue();
                }
            }


                Console.WriteLine(String.Join(" ", threads));
            

        }
    }
}
