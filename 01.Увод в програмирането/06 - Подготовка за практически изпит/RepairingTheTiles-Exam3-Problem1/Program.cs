using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairingTheTiles_Exam3_Problem1 {
    class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int O = int.Parse(Console.ReadLine());
            double area = Math.Pow(N, 2);
            area -= M * O;
            double tile_area = W * L;
            double amount = area / tile_area;
            double time = amount * 0.2;
            Console.WriteLine(amount);
            Console.WriteLine(time);
        }
    }
}
