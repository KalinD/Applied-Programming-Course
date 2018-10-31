using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunGlasses {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            //First row
            //Console.Write(new string('*', n * 2));
            //Console.Write(new string(' ', n));
            //Console.Write(new string('*', n * 2));
            //Console.WriteLine();
            Console.WriteLine($"{new string('*', n * 2)}" + $"{new string(' ', n)}" + $"{new string('*', n * 2)}");

            //Middle rows
            int spec = (n - 3) / 2;
            for (int i = 0; i < n - 2; i++) {
                Console.Write($"*{new string('/', (n * 2) - 2)}*");
                if (i == spec) {
                    Console.Write($"{new string('|', n)}");
                }
                else {
                    Console.Write($"{new string(' ', n)}");
                }
                Console.Write($"*{new string('/', (n * 2) - 2)}*");
                Console.WriteLine();
            }

            //Last row
            Console.WriteLine($"{new string('*', n * 2)}" + $"{new string(' ', n)}" + $"{new string('*', n * 2)}");
        }
    }
}
