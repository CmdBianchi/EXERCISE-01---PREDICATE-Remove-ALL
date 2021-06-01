using System;
using Entities;
using System.Collections.Generic;
namespace EXERCISE_01___PREDICATE_Remove_ALL {
    class Program {
        static void Main(string[] args) {

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.0));
            list.Add(new Product("Mouse",50.00));
            list.Add(new Product("Tablwt",350.00));
            list.Add(new Product("Mouse",50.00));

            list.RemoveAll(p => p.Price >= 100.0);
            foreach(Product p in list) {
                Console.WriteLine(p);
            }
        }
        public static bool ProductTest(Product p) {
            return p.Price >= 100.0;
        }
    }
}
