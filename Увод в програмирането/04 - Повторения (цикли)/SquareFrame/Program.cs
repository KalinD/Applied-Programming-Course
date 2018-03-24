using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if ((i == j && i == 0) || (i == n - 1 && j == 0)) {
                        Console.Write("+ ");
                    }
                    else if ((i == 0 && j == n - 1) || (i == n - 1 && j == i)) {
                        Console.WriteLine("+");
                    }
                    else if (j == 0) {
                        Console.Write("| ");
                    }
                    else if (j == n - 1) {
                        Console.WriteLine("|");
                    }
                    else {
                        Console.Write("- ");
                    }
                }
            }
        }
    }
}
