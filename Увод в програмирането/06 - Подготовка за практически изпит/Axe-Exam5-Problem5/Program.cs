using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe_Exam5_Problem5 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            for(; i < n; i++){
                Console.WriteLine($"{new string('-', n * 3)}*{new string('-', i)}*{new string('-', n * 2 - i - 2)}");
            }
            i = 0;
            for(; i < n / 2; i++){
                Console.WriteLine($"{new string('*', 3 * n + 1)}{new string('-', n - 1)}*{new string('-', n - 1)}");
            }
            i = 1;
            for (; i < n / 2; i++) {
                Console.WriteLine($"{new string('-', 3 * n - i)}*{new string('-', n + i * 2 - 1)}*{new string('-', n - i - 1)}");
            }
            Console.WriteLine($"{new string('-', 3 * n - i)}{new string('*', n + i * 2 + 1)}{new string('-', n - i - 1)}");
        }
    }
}
