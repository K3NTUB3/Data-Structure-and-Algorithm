using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_and_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool looping = true;

            Console.WriteLine("LESSONS");
            Console.WriteLine(" [0] Exit System");
            Console.WriteLine(" [1] Introduction to Data Structures");
            Console.WriteLine(" [2] Arrays V2");
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

            while (looping)
            {
                Console.Write("\nPick a Lesson: ");
                try
                {
                    int pick = Convert.ToInt32(Console.ReadLine());

                    if (pick == 0)
                    {
                        looping = false;
                        Console.WriteLine("That is all! Thank you!");
                    }
                    else if (pick < 0 || pick >= 15)
                    {
                        Console.WriteLine("Data Structure Lesson only has 14 lessons.");
                    }
                    else if (pick == 1)
                    {
                        LessonOne.Lesson1();
                    }
                    else if (pick == 2)
                    { 
                        LessonTwo.Lesson2();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

        }
    }
}
