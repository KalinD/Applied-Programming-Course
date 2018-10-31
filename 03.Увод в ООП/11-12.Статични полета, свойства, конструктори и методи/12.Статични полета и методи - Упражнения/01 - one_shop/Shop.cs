using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_shop {
    static class Shop {
        static Dictionary<string, Product> products = new Dictionary<string, Product>();

        static public void Sell(string barcode, double amount){
            if(products.ContainsKey(barcode) && products[barcode].Amount >= amount){
                products[barcode].Amount -= amount;
            }
            else{
                Console.WriteLine("Not enough quantity");
            }
        }

        static public void Add(string barcode, string name, double price, double amount){
            Product product = new Product(barcode, name, price, amount);
            products[barcode] = product;
        }

        static public void Update(string barcode, double amount) {
            if(products.ContainsKey(barcode)){
                products[barcode].Amount += amount;
            }
            else {
                Console.WriteLine("Please add your product first!");
            }
        }

        static public void PrintA(){
            foreach(var product in products.OrderBy(x => x.Value.Name).Where(x => x.Value.Amount > 0)){
                Console.WriteLine(product.Value.Name + " (" + product.Value.Barcode + ")");
            }
        }

        static public void PrintU() {
            foreach (var product in products.OrderBy(x => x.Value.Name).Where(x => x.Value.Amount <= 0)) {
                Console.WriteLine(product.Value.Name + " (" + product.Value.Barcode + ")");
            }
        }

        static public void PrintD() {
            foreach (var product in products.OrderByDescending(x => x.Value.Amount)) {
                Console.WriteLine(product.Value.Name + " (" + product.Value.Barcode + ")");
            }
        }

        static public double Calculate(){
            double total = 0;
            foreach(KeyValuePair<string, Product> product in products){
                total += product.Value.Amount * product.Value.Price;
            }
            return total;
        }
    }
}
