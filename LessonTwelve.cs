using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_and_Algorithm
{
    internal class LessonTwelve
    {
        public static void Lesson12()
        {
            int[] northRegionSales = { 100, 200, 150, 300 };
            int[] southRegionSales = { 120, 250, 180, 400 };
            int[] eastRegionSales = { 130, 220, 160, 350 };
            int[] westRegionSales = { 140, 230, 170, 450 };

            int totalNorthSales = CalculateTotalSales(northRegionSales);
            int totalSouthSales = CalculateTotalSales(southRegionSales);
            int totalEastSales = CalculateTotalSales(eastRegionSales);
            int totalWestSales = CalculateTotalSales(westRegionSales);

            int totalSales = totalNorthSales + totalSouthSales + totalEastSales + totalWestSales;

            Console.WriteLine("Total North Region Sales: " + totalNorthSales);
            Console.WriteLine("Total South Region Sales: " + totalSouthSales);
            Console.WriteLine("Total East Region Sales: " + totalEastSales);
            Console.WriteLine("Total West Region Sales: " + totalWestSales);
            Console.WriteLine("Total Sales (All Regions): " + totalSales);
        }
        static int CalculateTotalSales(int[] regionSales)
        {
            int total = 0;
            foreach (var sale in regionSales)
            {
                total += sale;
            }
            return total;
        }
    }
}
