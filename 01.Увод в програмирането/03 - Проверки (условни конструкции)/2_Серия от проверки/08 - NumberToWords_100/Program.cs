using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWords_100 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int number = n;
            number /= 10;
            if (n < 0 || n > 100) {
                Console.WriteLine("invalid number");
                n = -1;
            }
            if (number == 2) {
                Console.Write("twenty");
            }
            else if (number == 3) {
                Console.Write("thirty");
            }
            else if (number == 4) {
                Console.Write("forty");
            }
            else if (number == 5) {
                Console.Write("fifty");
            }
            else if (number == 6) {
                Console.Write("sixty");
            }
            else if (number == 7) {
                Console.Write("seventy");
            }
            else if (number == 8) {
                Console.Write("eighty");
            }
            else if (number == 9) {
                Console.Write("ninety");
            }
            if (n > 20 && n % 10 != 0) {
                Console.Write(" ");
            }
            if (n == 0) {
                Console.WriteLine("zero");
            }
            else if (n == 10) {
                Console.WriteLine("ten");
            }
            else if (n == 11) {
                Console.WriteLine("eleven");
            }
            else if (n == 12) {
                Console.WriteLine("twelve");
            }
            else if (n == 13) {
                Console.WriteLine("thirteen");
            }
            else if (n == 14) {
                Console.WriteLine("fourteen");
            }
            else if (n == 15) {
                Console.WriteLine("fifteen");
            }
            else if (n == 16) {
                Console.WriteLine("sixteen");
            }
            else if (n == 17) {
                Console.WriteLine("seventeen");
            }
            else if (n == 18) {
                Console.WriteLine("eighteen");
            }
            else if (n == 19) {
                Console.WriteLine("nineteen");
            }
            else if (n == 100) {
                Console.WriteLine("one hundred");
            }
            else if (n % 10 == 1) {
                Console.WriteLine("one");
            }
            else if (n % 10 == 2) {
                Console.WriteLine("two");
            }
            else if (n % 10 == 3) {
                Console.WriteLine("three");
            }
            else if (n % 10 == 4) {
                Console.WriteLine("four");
            }
            else if (n % 10 == 5) {
                Console.WriteLine("five");
            }
            else if (n % 10 == 6) {
                Console.WriteLine("six");
            }
            else if (n % 10 == 7) {
                Console.WriteLine("seven");
            }
            else if (n % 10 == 8) {
                Console.WriteLine("eight");
            }
            else if (n % 10 == 9) {
                Console.WriteLine("nine");
            }
        }
    }
}
