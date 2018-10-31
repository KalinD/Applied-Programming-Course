using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderOf2kPlus1 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int prev = 0;
            for (int i = 0; prev * 2 + 1 <= n; i++) {
                Console.WriteLine(prev * 2 + 1);
                prev = prev * 2 + 1;
            }
        }
    }
}
