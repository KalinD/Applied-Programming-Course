using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouse_updated_version {
    class Program {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ');
            long[] amount = new long[products.Length];
            long[] input_amount = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            Array.Copy(input_amount, amount, input_amount.Length);
            decimal[] prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            while (true)
            {
                string[] product = Console.ReadLine().Split(' ').ToArray();
                if (product[0] == "done")
                {
                    break;
                }
                int index = Array.IndexOf(products, product[0]);
                if(amount[index] - int.Parse(product[1]) >= 0){
                    int symbols = prices[index].ToString().Split('.')[1].Length;
                    Console.WriteLine($"{product[0]} x {product[1]} costs {(prices[index] * int.Parse(product[1])):f2}");
                    amount[index] -= int.Parse(product[1]);
                }
                else{
                    Console.WriteLine($"We do not have enough {product[0]}");
                }
            }
        }
    }
}
