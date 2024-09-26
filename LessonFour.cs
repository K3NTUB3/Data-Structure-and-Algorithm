using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_and_Algorithm
{
    internal class LessonFour
    {
        public static void Lesson4()
        {
            Stack<int> stack = new Stack<int>();

            Queue<int> queue = new Queue<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine("LIFO using Stack:");
            DisplayStackOperations(stack);

            Console.WriteLine("\nFIFO using Queue:");
            DisplayQueueOperations(queue);

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();

        }
        static void DisplayStackOperations(Stack<int> stack)
        {
            Console.WriteLine("Initial Stack:");
            DisplayStack(stack);

            Console.WriteLine("\nPopping elements from the Stack (LIFO):");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop() + " popped from the Stack.");
            }

            Console.WriteLine("\nFinal Stack (empty):");
            DisplayStack(stack);
        }
        static void DisplayQueueOperations(Queue<int> queue)
        {
            Console.WriteLine("Initial Queue:");
            DisplayQueue(queue);

            Console.WriteLine("\nDequeuing elements from the Queue (FIFO):");
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue() + " dequeued from the Queue.");
            }

            Console.WriteLine("\nFinal Queue (empty):");
            DisplayQueue(queue);
        }
        static void DisplayStack(Stack<int> stack)
        {
            if (stack.Count > 0)
            {
                foreach (int number in stack)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Stack is empty.");
            }
        }
        static void DisplayQueue(Queue<int> queue)
        {
            if (queue.Count > 0)
            {
                foreach (int number in queue)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Queue is empty.");
            }
        }
    }
}
