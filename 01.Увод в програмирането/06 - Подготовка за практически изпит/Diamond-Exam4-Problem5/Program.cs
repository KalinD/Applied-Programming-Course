using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_Exam4_Problem5 {
    class Program {
        static void Main(string[] args) {
            //first row
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{new string('.', n)}{new string('*', n * 3)}{new string('.', n)}");
            int i = 1;
            for(; i < n; i++){
                Console.WriteLine($"{new string('.', n - i)}*{new string('.', n * 3 + i * 2 - 2)}*{new string('.', n - i)}");
            }
            //middle row
            Console.WriteLine($"{new string('*', 5 * n)}");
            //bottom part
            i = 1;
            for(; i <= n * 2; i++){
                Console.WriteLine($"{new string('.', i)}*{new string('.', n * 5 - (i + 1) * 2)}*{new string('.', i)}");
            }
            //bottom row
            Console.WriteLine($"{new string('.', i)}{new string('*', n * 5 - i * 2)}{new string('.', i)}");
        }
    }
}
