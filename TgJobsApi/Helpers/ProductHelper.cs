using System.Collections.Generic;
using TgJobsApi.Models;

namespace TgJobsApi.Helpers
{
    public static class ProductHelper
    {
        public static List<Product> generateProducts()
        {
            List<Product> products = new List<Product>();

            Product product1 = new Product(3001, "Smartband", "Black", 24.99, 50);
            Product product2 = new Product(3002, "Smartwatch", "Red", 99.99, 90);
            Product product3 = new Product(3003, "Laptop", "White", 1226, 998);
            Product product4 = new Product(3004, "Mobile", "Black", 699, 500);
            Product product5 = new Product(3005, "Tablet", "Black", 244.49, null);

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);
            products.Add(product5);

            return products;
        }
    }
}
