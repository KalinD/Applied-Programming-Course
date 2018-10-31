using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_shop {
    static class Shop {
        static List<Product> products;

        static Shop(){
            products = new List<Product>();
        }

        public static void Sell(string code, double amount){
            foreach(var product in products){
                if(product.Barcode == code && product.Quantity >= amount){
                    product.Quantity -= amount;
                    return;
                }
            }
            Console.WriteLine("Not enough quantity");
        }

        public static void Add(string code, string name, double price, double quantity){
            Product product = new Product();
            product.Name = name;
            product.Barcode = code;
            product.Price = price;
            product.Quantity = quantity;
            products.Add(product);
        }

        public static void Update(string code, double amount){
            foreach(var product in products){
                if(product.Barcode == code){
                    product.Quantity += amount;
                    return;
                }
            }
            Console.WriteLine("Please add your product first!");
        }

        public static void PrintA(){
            foreach(var product in products.OrderBy(x => x.Name)){
                if(product.Quantity > 0){
                    Console.WriteLine($"{product.Name} ({product.Barcode})");
                }
            }
        }

        public static void PrintU() {
            foreach (var product in products.OrderBy(x => x.Name)) {
                if (product.Quantity == 0) {
                    Console.WriteLine($"{product.Name} ({product.Barcode})");
                }
            }
        }

        public static void PrintD() {
            foreach (var product in products.OrderByDescending(x => x.Quantity)) {
                if (product.Quantity > 0) {
                    Console.WriteLine($"{product.Name} ({product.Barcode})");
                }
            }
        }

        public static double Calculate() {
            return products.Sum(x => x.Price * x.Quantity);
        }
    }
}
