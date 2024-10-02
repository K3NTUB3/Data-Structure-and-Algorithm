using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_and_Algorithm
{
    internal class LessonEleven
    {
        public static void Lesson11()
        {
            int[] coins = { 1000, 500, 100, 50, 25, 10, 5, 1 };
            Console.Write("Enter the total amount:");
            int totalAmount = int.Parse(Console.ReadLine());

            GreedyAlgorithms.CoinChange(coins, totalAmount);
        }
    }
    public class GreedyAlgorithms
    {
        public static void CoinChange(int[] coins, int totalAmount)
        {
            Array.Sort(coins);
            Array.Reverse(coins);

            int coinCount = 0;
            Console.WriteLine("\nCoins used to make amount " + totalAmount + ":");

            foreach (int coin in coins)
            {
                while (totalAmount >= coin)
                {
                    totalAmount -= coin;
                    coinCount++;
                    Console.Write(coin + " ");
                }
            }

            if (totalAmount == 0)
                Console.WriteLine("\nTotal coins used: " + coinCount);
            else
                Console.WriteLine("\nCannot make the exact amount with given coins.");
        }
    }
}
