using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_and_Algorithm
{
    internal class LessonThirteen
    {
        static List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Widget", Category = "A", InStock = true },
            new Product { Id = 2, Name = "Gizmo", Category = "B", InStock = false },
            new Product { Id = 3, Name = "Gadget", Category = "A", InStock = true },
            new Product { Id = 4, Name = "Thingy", Category = "B", InStock = true }
        };
        public static void Lesson13()
        {
            Product result = FindProduct();

            if (result != null)
            {
                Console.WriteLine("Found Product: " + result.Name + " (Category: " + result.Category + ", In Stock: " + result.InStock + ")");
            }
            else
            {
                Console.WriteLine("No product found.");
            }
        }
        static Product FindProduct()
        {
            foreach (var product in Products)
            {
                if (product.Category == "A" && product.InStock)
                {
                    return product;
                }
            }
            foreach (var product in Products)
            {
                if (product.Category == "B" && product.InStock)
                {
                    return product;
                }
            }
            foreach (var product in Products)
            {
                if (product.Category == "A")
                {
                    return product;
                }
            }
            return null;
        }
    }
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public bool InStock { get; set; }
    }

}
