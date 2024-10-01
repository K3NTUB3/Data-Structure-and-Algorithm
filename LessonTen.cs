using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_and_Algorithm
{
    internal class LessonTen
    {
        public static void Lesson10()
        {
            string[] cars = { "Toyota", "Honda", "Ford", "Chevrolet", "BMW", "Mercedes", "Audi", "Volkswagen" };

            Console.WriteLine("Available cars: " + string.Join(", ", cars));
            Console.WriteLine("Enter the car name to search for:");
            string target = Console.ReadLine();

            int linearResult = SearchingAlgorithms.LinearSearch(cars, target);
            if (linearResult != -1)
                Console.WriteLine($"Linear Search: Car '{target}' found at index {linearResult}.");
            else
                Console.WriteLine($"Linear Search: Car '{target}' not found.");

            Array.Sort(cars);
            Console.WriteLine("Sorted car names for Binary Search:");
            Console.WriteLine(string.Join(", ", cars));

            int binaryResult = SearchingAlgorithms.BinarySearch(cars, target);
            if (binaryResult != -1)
                Console.WriteLine($"Binary Search: Car '{target}' found at index {binaryResult}.");
            else
                Console.WriteLine($"Binary Search: Car '{target}' not found.");
        }
    }
    public class SearchingAlgorithms
    {
        public static int LinearSearch(string[] arr, string target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(target, StringComparison.OrdinalIgnoreCase))
                    return i; 
            }
            return -1;
        }

        public static int BinarySearch(string[] arr, string target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid].Equals(target, StringComparison.OrdinalIgnoreCase))
                    return mid;

                if (string.Compare(arr[mid], target, StringComparison.OrdinalIgnoreCase) < 0)
                    left = mid + 1;

                else
                    right = mid - 1;
            }
            return -1;
        }
    }
}
