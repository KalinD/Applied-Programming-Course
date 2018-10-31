using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFort_Exam1_Problem5 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            //roof
            Console.WriteLine($"/{new string('^', n / 2)}\\{new string('_', 2 * n - (n / 2) * 2 - 4)}/{new string('^', n / 2)}\\");

            //middle
            for (int i = 0; i < n - 3; i++) {
                Console.WriteLine($"|{new string(' ', n * 2 - 2)}|");
            }

            //base
            Console.WriteLine($"|{new string(' ', n / 2 + 1)}{new string('_', 2 * n - (n / 2) * 2 - 4)}{new string(' ', n / 2 + 1)}|");
            Console.WriteLine($"\\{new string('_', n / 2)}/{new string(' ', 2 * n - (n / 2) * 2 - 4)}\\{new string('_', n / 2)}/");
        }
    }
}
