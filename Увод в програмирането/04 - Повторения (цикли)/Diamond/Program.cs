using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            //First half
            int stars;
            if (n % 2 == 0) {
                stars = 2;
            }
            else {
                stars = 1;
            }
            int dashes_l_r = (n - 1) / 2;
            while (dashes_l_r >= 0) {
                int mid = n - 2 * dashes_l_r - 2;
                Console.Write($"{new string('-', dashes_l_r)}");
                if (mid >= 1) {
                    Console.Write($"*{new string('-', mid)}*");
                }
                else {
                    Console.Write($"{new string('*', stars)}");
                }
                Console.Write($"{new string('-', dashes_l_r)}");
                Console.WriteLine();
                if (stars == 1) {
                    stars++;
                }
                dashes_l_r--;
            }
            //Second half
            dashes_l_r += 2;
            while (dashes_l_r * 2 < n) {
                int mid = n - 2 * dashes_l_r - 2;
                Console.Write($"{new string('-', dashes_l_r)}");
                if (mid >= 1) {
                    Console.Write($"*{new string('-', mid)}*");
                }
                else {
                    if (n % 2 == 0) {
                        Console.Write($"{new string('*', stars)}");
                    }
                    else {
                        Console.Write("*");
                    }
                }
                Console.Write($"{new string('-', dashes_l_r)}");
                Console.WriteLine();
                dashes_l_r++;
            }
        }
    }
}
