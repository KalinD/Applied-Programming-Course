using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree {
    class Program {
        static void Main(string[] args) {
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i <= size; i++) {
                int spaces = size - i;
                Console.Write(new string(' ', spaces));
                for (int j = 0; j < i; j++) {
                    Console.Write("*");
                }
                Console.Write(" | ");
                for (int j = 0; j < i; j++) {
                    Console.Write("*");
                }
                Console.Write(new string(' ', spaces));
                Console.WriteLine();
            }
        }
    }
}
