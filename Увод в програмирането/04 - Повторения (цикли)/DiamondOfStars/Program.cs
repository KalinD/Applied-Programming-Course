using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondOfStars {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                int stars = i;
                int spaces = n - stars;
                Console.Write(new string(' ', spaces));
                for (int j = 0; j < stars; j++) {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = n - 1; i > 0; i--) {
                int stars = i;
                int spaces = n - stars;
                Console.Write(new string(' ', spaces));
                for (int j = 0; j < stars; j++) {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
