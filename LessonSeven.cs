using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_and_Algorithm
{
    internal class LessonSeven
    {
        public static void Lesson7()
        {
            Dictionary<string, int> hashTable = new Dictionary<string, int>();

            hashTable.Add("Apple", 50);
            hashTable.Add("Banana", 30);
            hashTable.Add("Cherry", 25);

            Console.WriteLine("Price of Apple: " + hashTable["Apple"]);
            Console.WriteLine("Price of Banana: " + hashTable["Banana"]);

            if (hashTable.ContainsKey("Cherry"))
            {
                Console.WriteLine("Cherry is available, price: " + hashTable["Cherry"]);
            }

            hashTable["Banana"] = 35;
            Console.WriteLine("Updated price of Banana: " + hashTable["Banana"]);

            hashTable.Remove("Apple");
            Console.WriteLine("Apple removed from the hash table.");

            Console.WriteLine("\nCurrent items in the hash table:");
            foreach (var item in hashTable)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }

        }
    }

}
