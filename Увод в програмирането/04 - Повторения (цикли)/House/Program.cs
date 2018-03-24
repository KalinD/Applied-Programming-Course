using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            //Roof
            int stars;
            if (n % 2 == 0) {
                stars = 2;
            }
            else {
                stars = 1;
            }
            for (int i = 1; i <= (n + 1) / 2; i++) {
                int spaces = (n - stars) / 2;
                Console.Write(new string('-', spaces));
                for (int j = 0; j < stars; j++) {
                    Console.Write("*");
                }
                Console.Write(new string('-', spaces));
                Console.WriteLine();
                stars += 2;
            }

            //Body
            for (int i = 0; i <= n / 2 - 1; i++) {
                Console.WriteLine($"|{new string('*', n - 2)}|");
            }
        }
    }
}
