using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddSumMultiplication {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);
            Console.WriteLine(GetMultipleOfEvenAndOdds(n));
        }

        static int GetMultipleOfEvenAndOdds(int n) {
            return GetSumEven(n) * GetSumOdd(n);
        }

        static int GetSumEven(int n) {
            int sum = 0;
            while (n > 0) {
                int current = n % 10;
                if (current % 2 == 0) {
                    sum += current;
                }
                n /= 10;
            }
            return sum;
        }

        static int GetSumOdd(int n) {
            int sum = 0;
            while (n > 0) {
                int current = n % 10;
                if (current % 2 != 0) {
                    sum += current;
                }
                n /= 10;
            }
            return sum;
        }
    }
}
