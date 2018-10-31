using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            bool prime = true;
            if (n % 2 == 0 || n <= 1) {
                prime = false;
            }
            for (int i = 3; i <= Math.Sqrt(n); i++) {
                if (n % i == 0) {
                    prime = false;
                    break;
                }
            }
            if (prime) {
                Console.WriteLine("Prime");
            }
            else {
                Console.WriteLine("Not prime");
            }
        }
    }
}
