using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accurate_real_numbers {
    class Program {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal result = 0;
            for (int i = 0; i < n; i++){
                result += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(result);
        }
    }
}
