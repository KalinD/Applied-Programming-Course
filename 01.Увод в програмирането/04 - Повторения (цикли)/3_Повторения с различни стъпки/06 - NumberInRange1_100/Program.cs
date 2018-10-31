using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInRange1_100 {
    class Program {
        static void Main(string[] args) {
            int num = 0;
            for (; num < 1 || num > 100;) {
                Console.Write("Enter a number in the range [one...one hundred]: ");
                num = int.Parse(Console.ReadLine());
                if (num >= 1 && num <= 100) {
                    Console.WriteLine("The number is: " + num);
                }
                else {
                    Console.WriteLine("Invalid number!");
                }
            }
        }
    }
}
