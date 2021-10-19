using System;
using System.Collections;

namespace Practice_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex.1
            Queue q = new Queue();

            q.Enqueue("First");
            q.Enqueue("Second");
            q.Enqueue("Third");
            q.Enqueue("Fourth");

            while (q.Count > 0)
            {
                object obj = q.Dequeue();
                Console.WriteLine("Frome Queue: {0}", obj);
            }

            //ex.2
            Stack s = new Stack();

            s.Push("First");
            s.Push("Second");
            s.Push("Third");
            s.Push("Fourth");

            while (s.Count > 0)
            {
                object obj = s.Pop();
                Console.WriteLine("Frome Stack: {0}", obj);
            }
        }
    }
}
