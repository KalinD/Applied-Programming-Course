using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace floating_point_numbers {
    class Program {
        static void Main(string[] args)
        {
            decimal first = decimal.Parse(Console.ReadLine()); //3.141592653589793238
            double second = double.Parse(Console.ReadLine()); //1.60217657
            decimal third = decimal.Parse(Console.ReadLine()); //7.8184261974584555216535342341
            Console.WriteLine($"{first}\n{second}\n{third}");
        }
    }
}
