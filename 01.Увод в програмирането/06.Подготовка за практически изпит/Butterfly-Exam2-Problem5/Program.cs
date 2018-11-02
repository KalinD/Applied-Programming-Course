using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly_Exam2_Problem5 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            //upper part
            for(int i = 0; i < n - 2; i++){
                char sym = i % 2 == 0 ? '*' : '-';
                Console.WriteLine($"{new string(sym, n - 2)}\\ /{new string(sym, n - 2)}");
            }
            //middle
            Console.WriteLine($"{new string(' ', n - 1)}@");
            //bottom part
            for (int i = 0; i < n - 2; i++) {
                char sym = i % 2 == 0 ? '*' : '-';
                Console.WriteLine($"{new string(sym, n - 2)}/ \\{new string(sym, n - 2)}");
            }
        }
    }
}
