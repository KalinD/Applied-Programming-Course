using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop_Exam3_Problem5 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            //top row
            Console.WriteLine($"{new string('.', n + 1)}{new string('_', n * 2 + 1)}{new string('.', n + 1)}");
            for (int i = 0; i <= n; i++){
                Console.WriteLine($"{new string('.', n - i)}//{new string('_', (n + i) * 2 - 1)}\\\\{new string('.', n- i)}");
            }
            //middle row
            Console.WriteLine($"//{new string('_', (4*n - 5) / 2)}STOP!{new string('_', (4 * n - 5) / 2)}\\\\");
            for (int i = n; i > 0; i--) {
                Console.WriteLine($"{new string('.', n - i)}\\\\{new string('_', (n + i) * 2 - 1)}//{new string('.', n - i)}");
            }
        }
    }
}
