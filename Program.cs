using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_and_Algorithm
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("LESSONS");
            Console.WriteLine(" [0] Exit System");
            Console.WriteLine(" [1] Introduction to Data Structures");
            Console.WriteLine(" [2] Arrays");
            Console.WriteLine(" [3] Linked Lists");
            Console.WriteLine(" [4] Stacks and Queues");
            Console.WriteLine(" [5] Trees");
            Console.WriteLine(" [6] Graphs");
            Console.WriteLine(" [7] Hashing");
            Console.WriteLine(" [8] Heaps");
            Console.WriteLine(" [9] Sorting Algorithm");
            Console.WriteLine("[10] Searching Algorithm");
            Console.WriteLine("[11] Greedy Algorithm");
            Console.WriteLine("[12] Divide and Conquer");
            Console.WriteLine("[13] Backtracking");
            Console.WriteLine("[14] Space and Time Complexity Analysis");

            bool looping = true;

            while (looping)
            {
                Console.Write("\nChoose a Lesson: ");
                var input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    switch (number)
                    {
                        case 0:
                            looping = false;
                            Console.WriteLine("\nClosing Workloads...");
                            await Task.Delay(2000);
                            Console.WriteLine("\nSips Coffee...");
                            await Task.Delay(3000);
                            Console.WriteLine("\nHave a good day!\n");
                            break;
                        case 1:
                            Console.WriteLine("Hello this is Lesson 1");
                            break;
                        case 2:
                            Console.WriteLine("Hello this is Lesson 2");
                            break;
                        case 3:
                            Console.WriteLine("Hello this is Lesson 3");
                            break;
                        case 4:
                            Console.WriteLine("Hello this is Lesson 4");
                            break;
                        case 5:
                            Console.WriteLine("Hello this is Lesson 5");
                            break;
                        case 6:
                            Console.WriteLine("Hello this is Lesson 6");
                            break;
                        case 7:
                            Console.WriteLine("Hello this is Lesson 7");
                            break;
                        case 8:
                            Console.WriteLine("Hello this is Lesson 8");
                            break;
                        case 9:
                            Console.WriteLine("Hello this is Lesson 9");
                            break;
                        case 10:
                            Console.WriteLine("Hello this is Lesson 10");
                            break;
                        case 11:
                            Console.WriteLine("Hello this is Lesson 11");
                            break;
                        case 12:
                            Console.WriteLine("Hello this is Lesson 12");
                            break;
                        case 13:
                            Console.WriteLine("Hello this is Lesson 13");
                            break;
                        case 14:
                            Console.WriteLine("Hello this is Lesson 14");
                            break;
                        default:
                            Console.WriteLine("Enter number between 1 to 14");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a valid integer.");
                }
            }

        }
    }
}
