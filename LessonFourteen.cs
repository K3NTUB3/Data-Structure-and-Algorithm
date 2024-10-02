using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_and_Algorithm
{
    internal class LessonFourteen
    {
        public static void Lesson14()
        {
            Console.Write("Enter a string to reverse: ");
            string input = Console.ReadLine();

            Console.WriteLine("\nReversing string '" + input + "' using Iteration:");

            var startIterative = DateTime.Now;

            string reversedIterative = ReverseStringIterative(input);

            var endIterative = DateTime.Now;

            Console.WriteLine("Reversed String: "+ reversedIterative);

            Console.WriteLine("Time taken (Iterative): " + (endIterative - startIterative).TotalMilliseconds + " ms");

            Console.WriteLine("Space Complexity (Iterative): O(n) due to storing the reversed string");

            // ------------------------------------------------------------------------------------------------//

            Console.WriteLine("\nReversing string '" + input + "' using Recursion:");

            var startRecursive = DateTime.Now;

            string reversedRecursive = ReverseStringRecursive(input);
            
            var endRecursive = DateTime.Now;

            Console.WriteLine("Reversed String: " + reversedRecursive);
            
            Console.WriteLine("Time taken (Recursive): " + (endRecursive - startRecursive).TotalMilliseconds + " ms");

            Console.WriteLine("Space Complexity (Recursive): O(n) due to the call stack and storing the reversed string");
        }
        static string ReverseStringIterative(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static string ReverseStringRecursive(string str)
        {
            if (str.Length == 0)
                return str;
            return str[str.Length - 1] + ReverseStringRecursive(str.Substring(0, str.Length - 1));
        }
    }
}
