using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLCD__NOD_ {
    class Program {
        static void Main(string[] args) {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            while (num2 != 0) {
                int old = num2;
                num2 = num1 % num2;
                num1 = old;
            }
            Console.WriteLine(num1);
        }
    }
}
