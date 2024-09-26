using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_and_Algorithm
{
    internal class LessonThree
    {
        public static void Lesson3()
        {
            LinkedListOperations operations = new LinkedListOperations();

            Console.WriteLine("Current LinkedList elements:");
            operations.DisplayLinkedList();

            Console.WriteLine("\nEnter a number to add to the LinkedList:");
            int newNumber;
            if (int.TryParse(Console.ReadLine(), out newNumber))
            {
                operations.AddNumber(newNumber);
            }

            Console.WriteLine("\nUpdated LinkedList elements:");
            operations.DisplayLinkedList();

            Console.WriteLine("\nEnter a number to remove from the LinkedList:");
            if (int.TryParse(Console.ReadLine(), out newNumber))
            {
                operations.RemoveNumber(newNumber);
            }

            Console.WriteLine("\nFinal LinkedList elements:");
            operations.DisplayLinkedList();

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
    class LinkedListOperations
    {
        private LinkedList<int> numbers;

        public LinkedListOperations()
        {
            numbers = new LinkedList<int>();
            numbers.AddLast(10);
            numbers.AddLast(20);
            numbers.AddLast(30);
            numbers.AddFirst(5);
        }
        public void AddNumber(int number)
        {
            numbers.AddLast(number);
            Console.WriteLine(number + " added to the LinkedList.");
        }
        public void RemoveNumber(int number)
        {
            if (numbers.Contains(number))
            {
                numbers.Remove(number);
                Console.WriteLine(number + " removed from the LinkedList.");
            }
            else
            {
                Console.WriteLine(number + " not found in the LinkedList.");
            }
        }
        public void DisplayLinkedList()
        {
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}