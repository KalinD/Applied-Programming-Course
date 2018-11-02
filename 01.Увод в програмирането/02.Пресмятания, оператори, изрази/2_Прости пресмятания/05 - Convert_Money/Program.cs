using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Money {
    class Program {
        static void Main(string[] args) {
            double money = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();
            if (from == "USD") {
                money *= 1.79549;
            }
            else if (from == "EUR") {
                money *= 1.95583;
            }
            else if (from == "GBP") {
                money *= 2.53405;
            }
            if (to == "USD") {
                money /= 1.79549;
            }
            else if (to == "EUR") {
                money /= 1.95583;
            }
            else if (to == "GBP") {
                money /= 2.53405;
            }
            Console.WriteLine(Math.Round(money, 2) + " " + to);
        }
    }
}
