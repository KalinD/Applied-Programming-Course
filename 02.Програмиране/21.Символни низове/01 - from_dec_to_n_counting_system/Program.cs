using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace from_dec_to_n_counting_system {
    class Program {
        static void Main(string[] args) {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //0 - broina sistema ; 1 - chislo
            int result = 0;
            while (list[1] > 0) {
                result = result * 10 + list[1] % list[0];
                list[1] /= list[0];
            }
            Console.WriteLine(result);
            int reverse = 0;
            while(result > 0){
                reverse = reverse * 10 + result % 10;
                result /= 10;
            }
            Console.WriteLine(reverse);
            //Console.WriteLine(result.ToString().Reverse().Aggregate(0, (b, x) => 10 * b + x - '0'));
        }
    }
}
