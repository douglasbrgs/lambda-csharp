using Course01.Entities;
using System;
using System.Collections.Generic;

namespace Course01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("TV", 900.0));
            products.Add(new Product("Notebook", 1200.0));
            products.Add(new Product("Tablet", 450.0));

            products.Sort(CompareProducts);

            foreach (Product prod in products)
            {
                Console.WriteLine(prod);
            }
        }

        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}
