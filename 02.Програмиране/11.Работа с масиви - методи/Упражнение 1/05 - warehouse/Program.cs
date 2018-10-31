using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouse {
    class Program {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ');
            long[] amount = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            while (true)
            {
                string product = Console.ReadLine();
                if (product == "done")
                {
                    break;
                }
                int index = Array.IndexOf(products, product);
                int symbols = prices[index].ToString().Split('.')[1].Length;
                Console.WriteLine($"{product} costs: {prices[index].ToString($"0.{new string('0', symbols)}")}; Available quantity: {amount[index]}");
            }
        }
    }
}
