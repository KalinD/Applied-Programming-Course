using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Area {
    class Program {
        static void Main(string[] args) {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Abs(x1 - x2) * Math.Abs(y1 - y2));
            Console.WriteLine((Math.Abs(x1 - x2) + Math.Abs(y1 - y2)) * 2);
        }
    }
}
