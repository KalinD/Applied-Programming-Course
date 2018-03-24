using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice_Exam1_Problem2 {
    class Program {
        static void Main(string[] args) {
            double distance = double.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double price;
            if (distance >= 100) {
                price = 0.06 * distance;
            }
            else if (distance >= 20) {
                price = 0.09 * distance;
            }
            else {
                if (time == "day") {
                    price = 0.7 + 0.79 * distance;
                }
                else {
                    price = 0.7 + 0.9 * distance;
                }
            }
            Console.WriteLine(price);
        }
    }
}
