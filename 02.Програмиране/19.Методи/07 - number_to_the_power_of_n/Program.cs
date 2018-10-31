using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_to_the_power_of_n {
    class Program {
        static void Main(string[] args) {
            double a = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Power(a, n));
        }
        static double Power(double a, int n){
            double result = 1;
            for (int i = 0; i < n; i++){
                result *= a;
            }
            return result;
            //return Math.Pow(a, n);
        }
    }
}
