using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WholeNumberSign {
    class Program {

        static void Main(string[] args) {
            int number = int.Parse(Console.ReadLine());
            PosOrNeg(number);
        }

        static void PosOrNeg(int num) {
            if (num < 0) {
                Console.WriteLine($"The number {num} is negative.");
            }
            else if (num == 0) {
                Console.WriteLine("The number 0 is zero.");
            }
            else {
                Console.WriteLine($"The number {num} is positive.");
            }
        }
    }
}
