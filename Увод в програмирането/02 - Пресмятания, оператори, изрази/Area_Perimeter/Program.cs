using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Perimeter {
    class Program {
        static void Main(string[] args) {
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(Math.Pow(a, 2) * Math.PI, 2));
            Console.WriteLine(Math.Round(a * Math.PI * 2, 2));
        }
    }
}
