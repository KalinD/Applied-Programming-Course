using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket_Exam2_Problem1 {
    class Program {
        static void Main(string[] args) {
            double vegetable = double.Parse(Console.ReadLine());
            double fruit = double.Parse(Console.ReadLine());
            double v_amount = double.Parse(Console.ReadLine());
            double f_amount = double.Parse(Console.ReadLine());
            Console.WriteLine((vegetable * v_amount + fruit * f_amount) / 1.94);
        }
    }
}
