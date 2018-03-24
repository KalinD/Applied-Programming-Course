using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter {
    class Program {
        static void Main(string[] args) {
            double amount = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();
            if (from == "mm") {
                amount /= 1000;
            }
            else if (from == "cm") {
                amount /= 100;
            }
            else if (from == "mi") {
                amount /= 0.000621371192;
            }
            else if (from == "in") {
                amount /= 39.3700787;
            }
            else if (from == "km") {
                amount /= 0.001;
            }
            else if (from == "ft") {
                amount /= 3.2808399;
            }
            else if (from == "yd") {
                amount /= 1.0936133;
            }
            if (to == "mm") {
                amount *= 1000;
            }
            else if (to == "cm") {
                amount *= 100;
            }
            else if (to == "mi") {
                amount *= 0.000621371192;
            }
            else if (to == "in") {
                amount *= 39.3700787;
            }
            else if (to == "km") {
                amount *= 0.001;
            }
            else if (to == "ft") {
                amount *= 3.2808399;
            }
            else if (to == "yd") {
                amount *= 1.0936133;
            }
            Console.WriteLine(amount + " " + to);
        }
    }
}
