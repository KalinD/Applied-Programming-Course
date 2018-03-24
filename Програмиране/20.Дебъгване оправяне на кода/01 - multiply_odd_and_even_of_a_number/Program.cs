using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiply_odd_and_even_of_a_number {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);
            Console.WriteLine(GetMultipleOfEvenAndOdds(n));
        }
        static int GetMultipleOfEvenAndOdds(int num){
            int even = SumOfEven(num);
            int odd = SumOfOdd(num);
            return even * odd;
        }
        static int SumOfEven(int num){
            int sum = 0;
            while(num > 0){
                if((num % 10) % 2 == 0){
                    sum += num % 10;
                }
                num /= 10;
            }
            return sum;
        }
        static int SumOfOdd(int num){
            int even = SumOfEven(num);
            int sum = 0;
            while(num > 0){
                sum += num % 10;
                num /= 10;
            }
            return sum - even;
        }
    }
}
