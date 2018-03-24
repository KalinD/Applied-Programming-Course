using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigitsOfNumber {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int final = 0;
            while (n > 0) {
                final += n % 10;
                n /= 10;
            }
            Console.WriteLine(final);
        }
    }
}
