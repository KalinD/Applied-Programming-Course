using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket {
    class Program {
        static void Main(string[] args) {
            Dictionary<string, double[]> supermarket = new Dictionary<string, double[]>();
            while (true){
                List<string> stock = Console.ReadLine().Split(' ').ToList();
                if(stock[0]== "stocked"){
                    break;
                }
                if(supermarket.ContainsKey(stock[0])){
                    supermarket[stock[0]][0] = double.Parse(stock[1]);
                    supermarket[stock[0]][1] += double.Parse(stock[2]);
                    continue;
                }
                double[] toAdd = {double.Parse(stock[1]), double.Parse(stock[2])};
                supermarket[stock[0]] = toAdd;
            }
            double price = 0;
            foreach(var item in supermarket){
                Console.WriteLine($"{item.Key}: ${item.Value[0]:f2} * {item.Value[1]} = ${item.Value[0] * item.Value[1]:f2}");
                price += item.Value[0] * item.Value[1];
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand total: ${price:f2}");
        }
    }
}
