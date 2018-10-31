using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divide_whole_nums {
    class Program {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int remainder = 0;
            for (int i = 0; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                remainder += num1 % num2;
            }
            Console.WriteLine(remainder);
        }
    }
}
