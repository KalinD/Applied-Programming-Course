using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFillRectangle {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            Square(n);
        }
        static void Header(int n) {
            Console.WriteLine($"{new string('-', n * 2)}");
        }
        static void Square(int n) {
            Header(n);
            for (int i = 0; i < n - 2; i++) {
                Console.Write("-");
                for (int j = 0; j < n - 1; j++) {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
            Header(n);
        }
    }
}
