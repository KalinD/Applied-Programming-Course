using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema {
    class Program {
        static void Main(string[] args) {
            var type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (type == "Premiere") {
                Console.WriteLine("{0:f2}", 12.0 * r * c);
            }
            else if (type == "Normal") {
                Console.WriteLine("{0:f2}", 7.50 * r * c);
            }
            else if (type == "Discount") {
                Console.WriteLine("{0:f2} leva", 5.00 * r * c, 2);
            }
        }
    }
}
