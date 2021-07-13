﻿using System;
using System.Collections.Generic;
using ComparisonT.Entities;

namespace ComparisonT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.0));
            list.Add(new Product("Notebook", 1200.0));
            list.Add(new Product("Tablet", 450.0));

            Comparison<Product> comparison = CompareProducts;

            list.Sort(comparison);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}
